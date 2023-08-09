namespace Generic_exercise.Entities
{
    internal class Mage : IGameCharacter
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Level: {Level}";
        }
    }

}
