﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.Identity
{
    public class RoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
