﻿/*
 * CheckupToOtherLightModel
 * Autor: Michal Šedý <xsedym02>, Ondřej Pavlacký <xpavla15, Kateřina Kunorzová <xkunor00>
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nemocnice.Models
{
    public class CheckupToOtherLightModle
    {
        public DateTime CreateDate { get; set; }
        public string ToDoctor { get; set; }
        public string State { get; set; }
    }
}
