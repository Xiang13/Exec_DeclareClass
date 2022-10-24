using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareClass
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}

	// 宣告 Address 類別
	class Address
	{
		public string City { get; set; }
		public string ZipCode{ get; set; }
		public string Street{ get; set; }

	}

	// 宣告 Telephone 類別
	class Telephone
	{
		public string CountryCode { get; set; }
		public string AreaCode{ get; set; }
		public string Number{ get; set; }
		public string Ext { get; set; }

	}

	// 宣告 Member 類別
	class Member
	{
		public Address Addr { get; set; }
		public Telephone Telep { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string Cellphone { get; set; }


		public void Register(string name, string account, string password, string confirmpassword, string email)
		{

		}
		public void ForgetPassword(Member Name, Member Email)
		{

		}
		public bool Authenticate(Member Account, Member Password)
		{
			return true;
		}
	}
		
}
