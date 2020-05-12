﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using BCrypt;
namespace mazeprojetynov
{
	public class Hashing
	{
		private  string GetRandomSalt()
		{
			
			return BCrypt.Net.BCrypt.GenerateSalt(12);
		}

		public  string HashPassword(string password)
		{
			return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
		}

		public  bool ValidatePassword(string password, string correctHash)
		{
			return BCrypt.Net.BCrypt.Verify(password, correctHash);
		}
	}
}
