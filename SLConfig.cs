using System;
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace ScriptLauncher
{
	public class SLConfig
	{
		private static string dataPath = Application.LocalUserAppDataPath;
		private static string configPath = dataPath + "\\config.xml";

		private static XmlNodeList cats;
		private static ArrayList cmdList = new ArrayList();
		private static ArrayList categories = new ArrayList();

		public SLConfig()
		{
			ParseConfig();
		}

		public ArrayList CMDList
		{
			get { return cmdList; }
			private set {;}
		}

		public ArrayList Categories
		{
			get { return categories; }
			private set {;}
		}

		// Debug helper function. (Less typing)
		private static void Dbg (String str)
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
					XmlDocument xconfig = new XmlDocument();
					xconfig.Load(configPath);
					cats = xconfig.DocumentElement.SelectNodes("/config/category");

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
	}
}
