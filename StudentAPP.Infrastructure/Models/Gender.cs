﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPP.Infrastructure.Models
{
    public class Gender
    {
        [Key]
        public int GenderID { get; set; }
        public string GenderName { get; set; }
    }
}
