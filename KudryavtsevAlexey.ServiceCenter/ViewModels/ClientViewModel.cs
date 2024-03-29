﻿using System.ComponentModel.DataAnnotations;

namespace KudryavtsevAlexey.ServiceCenter.ViewModels
{
	public class ClientViewModel
    {
	    [EmailAddress, Required, Display(Name = "Your email")]
	    public string Email { get; set; }
		[Required, Display(Name = "Your first name")]
		public string FirstName { get; set; }
		[Required, Display(Name = "Your last name")]
		public string LastName { get; set; }
    }
}
