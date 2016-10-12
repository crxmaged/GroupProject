﻿namespace Common.modal
{
    class Birds: IAnimal
    {
        public int Id { get; set; }
        public TypeAnimal Type { get; set; }
        public BirdsRace BirdsRace { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }

     
    }
    internal enum BirdsRace
    {
        Raven = 1,
        Dove = 2,
        Falcon = 3,
        Owl = 4,
        Parrot = 5,
        Penguin = 6,
        Eagle = 7,
        Woodpecker = 8,
        Flamingo = 9,
        Chicken = 10
    }
}