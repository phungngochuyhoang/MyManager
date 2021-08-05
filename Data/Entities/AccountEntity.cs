using System.Collections.Generic;
using System.Linq;
using System;

namespace Manager.Data.Entities
{
    public class AccountEntity: BaseEntity
    {
        
        public string AccountName { get; set;}

        public string Password { get; set; }

        public DateTime DateTimeCurrent { get; set; }
    }

}