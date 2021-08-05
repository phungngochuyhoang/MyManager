using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace Manager.Data
{
    public abstract class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set;}
    }

}