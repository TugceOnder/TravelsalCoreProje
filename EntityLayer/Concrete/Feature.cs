﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
         public string Image { get; set; }
        public bool Status { get; set; }

        
    }
}
