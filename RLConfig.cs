﻿using System;
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RocketLauncher
{
	public class RLConfig
	{
		private static string dataPath = Application.LocalUserAppDataPath;
		private static string configPath = dataPath + "\\config.xml";

		//private static XmlNodeList cats;
		private static List<CmdItem> cmdList = new List<CmdItem>();
		private static List<string> categories = new List<string>();

		public RLConfig()
		{
			ParseConfig();
		}

		public List<CmdItem> CMDList
		{
			get { return cmdList; }
			private set {;}
		}

		public List<string> Categories
		{
			get { return categories; }
			private set {;}
		}

		// Debug helper function. (Less typing)
		public static void Dbg (String str)
		{
			System.Diagnostics.Debug.WriteLine(str);
		}

		//Read and parse config from config.xml file. 
		//Populates the config arrays, but does not create any menu items. 
		public static void ParseConfig()
		{
            Dbg("Attempting to parse config.xml");
            FileStream configFile; 
			if (File.Exists(configPath))
			{
                Dbg("Reading config: " + configPath);
                configFile = new FileStream(configPath, FileMode.Open, FileAccess.Read);
                try
				{
                    XmlReader xmlconfig = XmlReader.Create(configFile);

                    while (xmlconfig.Read())
                    {
                        if (xmlconfig.NodeType == XmlNodeType.Element && xmlconfig.Name == "category")
                        {
                            string catName = xmlconfig.GetAttribute("name");
                            categories.Add(catName);
                            
                            XmlReader xmlsubtree = xmlconfig.ReadSubtree();
                            while (xmlsubtree.Read())
                            {
                                if (xmlsubtree.NodeType == XmlNodeType.Element && xmlsubtree.Name == "cmd")
                                {
                                    cmdList.Add(new CmdItem(
                                        catName,
                                        xmlsubtree.GetAttribute("name"),
                                        xmlsubtree.GetAttribute("value")
                                    ));
                                }
                            }
                            xmlsubtree.Close();
                        }
                    }
                    xmlconfig.Close();
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine("EXCEPTION" + ex.Message);
				}
				finally
				{
					// Print out final array lengths:
                    Dbg("Done parsing config.");
                    Dbg("Categories: " + categories.Count.ToString());
					Dbg("Commands: " + cmdList.Count.ToString());
                    //Close the FileStream
                    configFile.Close();
				}
			}
            else if (!File.Exists(configPath))
            {
                Dbg("No config file found. Creating new empty config.xml");
                CreateNewConfigFile();
            }
		}

		// Searches command list for a command name, returns the index of the first match. 
        public static int FindCmdByName(string searchName)
		{
			int searchIndex = -1;
			foreach (CmdItem current in cmdList)
			{
				if (current.Name.Equals(searchName))
				{
					searchIndex = cmdList.IndexOf(current);
				}
			}
			return searchIndex; 
            //TODO: what happens if multiple commands have the same name? 
            //We'll always return the first one with that name. 
            //Is that okay, or is there a bug to fix here? 
		}

		public static void AddCategory(string addcat)
		{
			categories.Add(addcat);
            RebuildXMLConfig();
		}

		// Renames a category in the category list. 
		// Also updates all commands with the same category name from the cmdList. 
		public static void RenameCategory(string oldCatName, string newCatName)
		{
			int replaceIndex = categories.IndexOf(oldCatName);
			Dbg("Replace: Old category: " + oldCatName + " - Index: " + replaceIndex);
			categories.RemoveAt(replaceIndex);
			categories.Insert(replaceIndex, newCatName);

			for (int i = 0; i < cmdList.Count; i++)
			{
				CmdItem current = cmdList[i];
				if (current.Category == oldCatName)
				{
					CmdItem renamed = new CmdItem(newCatName, current.Name, current.Value);
					cmdList.Insert(i, renamed);
					cmdList.Remove(current);
					Dbg("renaming: " + current.ToString() + " to " + renamed.ToString());
				}
			}
            RebuildXMLConfig();
		}

		public static void AddCommand(string addCat, string addName, string addcmd)
		{
			cmdList.Add(new CmdItem(addCat, addName, addcmd));
            RebuildXMLConfig();
		}

		// Is called if a category gets renamed.
        public static void UpdateCommandCategories(string oldCmdName, string newCmdName)
		{
			int replaceIndex = FindCmdByName(oldCmdName);
			CmdItem delCmd = cmdList[replaceIndex];
			cmdList.Insert(replaceIndex, new CmdItem(delCmd.Category, newCmdName, delCmd.Value));
			cmdList.Remove(delCmd);
            RebuildXMLConfig();
		}

        // Used to replace/rename/modify existing commands. 
        public static void ReplaceCommand(int replaceIndex, CmdItem replaceCmd)
        {
            CmdItem delCmd = cmdList[replaceIndex];
            cmdList.Insert(replaceIndex, replaceCmd);
            cmdList.Remove(delCmd);
            RebuildXMLConfig();
        }

		public static void DeleteCommand(int delIndex)
		{
			cmdList.RemoveAt(delIndex);
            RebuildXMLConfig();
		}

		public static void DeleteCategory(string delCategory)
		{
			// First delete all command entries from CMD list. 
			for (int i = 0; i < cmdList.Count; i++)
			{
				CmdItem current = cmdList[i];
				if (current.Category == delCategory)
				{
					cmdList.Remove(current);
				}
			}
			// Next, delete the category from cat list. 
			for  (int i = 0; i < categories.Count; i++)
			{
				if (delCategory == categories[i])
				{
					categories.RemoveAt(i);
				}
			}
            RebuildXMLConfig();
		}

		// XML READ/WRITE FUNCTIONS 
        
        // Creates a new empty config.xml file if none exists. 
        private static void CreateNewConfigFile()
        {
            using (FileStream configFile = new FileStream(configPath, FileMode.CreateNew, FileAccess.Write))
            {
                try
                {
                    configFile.Close();
                }
                catch (Exception ex)
                {
                    Dbg(ex.Message);
                }
            }
        }
        
        // Used to rewrite the config.xml file each time an edit is made
        // to a category or a command in the UI. 
        // Is called by most edit functions in this class. 
        private static void RebuildXMLConfig()
        {
            XmlDocument newConfig = new XmlDocument();
            XmlDeclaration xmldec = newConfig.CreateXmlDeclaration("1.0", "UTF-8", null);
            newConfig.AppendChild(xmldec);
            XmlElement configNode = newConfig.CreateElement("config");
            newConfig.AppendChild(configNode);
            
            foreach (string c in categories)
            {
                XmlElement catElement = newConfig.CreateElement("category");
                catElement.SetAttribute("name", c);
                catElement.SetAttribute("value", c);
                newConfig.DocumentElement.AppendChild(catElement);
                
                XmlElement cmdElement;
                foreach (CmdItem cmd in cmdList)
                {
                    if (cmd.Category.ToLower() == c.ToLower())
                    {
                        cmdElement = newConfig.CreateElement("cmd");                        
                        cmdElement.SetAttribute("name", cmd.Name);
                        cmdElement.SetAttribute("value", cmd.Value);
                        catElement.AppendChild(cmdElement);
                    }
                }
            }

            using (FileStream configFile = new FileStream(configPath, FileMode.Open, FileAccess.Write)) 
            { 
                try
                {
                    newConfig.Save(configFile);
                } 
                catch (Exception ex)
                {
                    Dbg(ex.Message);
                }
            }
        }
	}
}

