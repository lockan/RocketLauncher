using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptLauncher
{
	public class CmdItem
	{
		private string cmd_category;
		private string cmd_name;
		private string cmd_value;

		public CmdItem(string cat, string name, string val)
		{
			this.cmd_category = cat;
			this.cmd_name = name;
			this.cmd_value = val;
		}
		
		public string Category
		{
			set { this.cmd_category = value; }
			get { return this.cmd_category; }
		}

		public string Name
		{
			set { this.cmd_name = value; }
			get { return this.cmd_name; }
		}

		public string Value
		{
			set { this.cmd_value = value; }
			get { return this.cmd_value; }
		}

		public override string ToString()
		{
			return cmd_category + " - " + cmd_name + " - " + cmd_value;
		}
	}
}

	

	
