﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venus.AI.WebApi.Models.Exceptions
{
    public class InvalidIdExcrption : Exception
    {
        public InvalidIdExcrption() : base("invalid Id")
        {
        }
    }
}
