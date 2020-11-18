using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffershop1
{
	public class LoginAccount
	{

		public string id { get; set; }
		public string name { get; set; }

		public string master { get; set; }

		public LoginAccount(string id, string name, string master)
		{
			this.id = id;
			this.name = name;
			this.master = master;
		}
	}
}
