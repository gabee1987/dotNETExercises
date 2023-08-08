﻿namespace Generic_exercise.Entities
{
    internal class Rogue : IGameCharacter
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Health: {Health}";
        }
    }
}
