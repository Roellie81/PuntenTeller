﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuntenTeller.Models
{
    public class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
    }
}
