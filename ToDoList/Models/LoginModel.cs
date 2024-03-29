﻿using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class LoginModel
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
