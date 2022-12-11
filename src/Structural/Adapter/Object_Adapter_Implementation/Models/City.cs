﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Object_Adapter_Implementation.Models
{
    public class City
    {
        public string FullName { get; private set; }
        public long Inhabitants { get; private set; }
        public City(string fullName, long inhabitants)
        {
            FullName = fullName;
            Inhabitants = inhabitants;
        }
    }
}
