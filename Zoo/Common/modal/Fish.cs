﻿using System;

namespace Common.modal
{
    class Fish:IAnimal
    {
       public int Id { get; set; }
        public TypeAnimal Type { get; set; }
        public FishRace FishRace { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
    }
    internal enum FishRace
    {
        Shark = 1,
        Skate = 2,
        Piranha = 3,
        Pike = 4,
        Cartfish = 5,
        Dolphin = 6
    }
}
