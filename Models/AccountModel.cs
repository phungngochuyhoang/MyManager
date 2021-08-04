using System;
using System.ComponentModel.DataAnnotations;

namespace Manager.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string AccountName { get; set; }       
        public string Password { get; set; }

    }
}