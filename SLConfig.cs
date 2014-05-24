using System;
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScriptLauncher
{
	public class SLConfig
	{
		private static string dataPath = Application.LocalUserAppDataPath;
		private static string configPath = dataPath + "\\config.xml";

		private static XmlNodeList cats;
		private static List<CmdItem> cmdList = new List<CmdItem>();
		private static List<string> categories = new List<string>();

		public SLConfig()
		{
			//ParseConfig();
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
			Dbg("Reading " + configPath);
			if (File.Exists(configPath))
			{
				try
				{
					XmlDocument xmlconfig = new XmlDocument();
					xmlconfig.Load(configPath);
					cats = xmlconfig.DocumentElement.SelectNodes("/config/category");

					for (int i = 0; i < cats.Count; i++)
					{
						string catName = cats.Item(i).Attributes["name"].InnerText;
						categories.Add(catName);

						XmlNodeList links = cats.Item(i).ChildNodes;
						for (int j = 0; j < links.Count; j++)
						{
							cmdList.Add(new CmdItem(
								cats.Item(i).Attributes["name"].InnerText,
								links.Item(j).Attributes["name"].InnerText,
								links.Item(j).Attributes["value"].InnerText
								));
						}
					}
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine("EXCEPTION" + ex.Message);
				}
				finally
				{
					// Print out final array lengths:
					Dbg("Categories: " + categories.Count.ToString());
					Dbg("Commands: " + cmdList.Count.ToString());
				}

			}
		}

		private static int FindCmdByName(string searchName)
		{
			int searchIndex = -1;
			foreach (CmdItem current in cmdList)
			{
				if (current.Name.Equals(searchName))
				{
					searchIndex = cmdList.IndexOf(current);
				}
			}
			return searchIndex; //TODO: what happens if multiple commands have the same name? 
		}

		public static void AddCategory(string addcat)
		{
			categories.Add(addcat);
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
		}

		public static void AddCommand(string addCat, string addName, string addcmd)
		{
			cmdList.Add(new CmdItem(addCat, addName, addcmd));
		}

		public static void RenameCommand(string oldCmdName, string newCmdName)
		{
			int replaceIndex = FindCmdByName(oldCmdName);
			CmdItem delCmd = cmdList[replaceIndex];
			cmdList.Insert(replaceIndex, new CmdItem(delCmd.Category, newCmdName, delCmd.Value));
			cmdList.Remove(delCmd);
		}

	}
}
