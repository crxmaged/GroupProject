﻿using System;
using System.Collections.Generic;
using UserProject.Interfaces;

namespace UserProject.Characters
{
    internal  class Recruit : Character, IUser
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}