using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptLauncher
{
	struct CmdItem
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
			private set { this.cmd_category = value; }
			get { return this.cmd_category; }
		}

		public string Name
		{
			private set { this.cmd_name = value; }
			get { return this.cmd_name; }
		}

		public string Value
		{
			private set { this.cmd_value = value; }
			get { return this.cmd_value; }
		}
	}
}

	

	
