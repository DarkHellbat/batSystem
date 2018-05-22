﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace batSystem.Models
{
    public class CreateNewUserModel
    {
        //public User user;
        //public CreateNewUserModel()
        //{
        //    user = new User();
        //}
        //public User GetUser()
        //{

        //}
        [Display (Name ="Логин")]
        [Required]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [Required]
        public string Password { get; set; }
        [Display(Name = "Фамилия")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Имя")]
        [Required]
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public File Avatar { get; set; }
        
        [Required]
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
        public Enum Status { get; set; }
        //[Required]
        public UserGroup InGroup { get; set; }
    }
}