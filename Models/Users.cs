﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsiFront.Models
{
	public class Users
	{
		public int id { get; set; }
		public String name { get; set; }

		public String lastName { get; set; }

		public String addresse { get; set; }

		public String sexe { get; set; }

		public String email { get; set; }

		public String password { get; set; }

		public Role role { get; set; }



		public Users (String name1 , String password1)
        {
			name = name1;
			password = password1;

		}

		public Users()
		{

		}




	}
}