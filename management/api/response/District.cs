﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.api.response
{
    public class District
    {
        public string code { get; set; }
        public string name { get; set; }
        public string province { get; set; }
    }

    public class DistrictResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public List<District> results { get; set; }
    }
}
