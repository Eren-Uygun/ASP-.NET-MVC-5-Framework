﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_HtmlHelper.MODEL.Entity
{
   public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public String Description { get; set; }
    }
}