﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonaialID { get; set; }
        public string Client { get; set; }
        public string Comment { get; set; } 
        public string ClientImage { get; set; }
        public bool Status { get; set; }
    }
}
