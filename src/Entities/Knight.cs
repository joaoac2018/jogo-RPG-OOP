namespace src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int level, string heroType)
        {
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;     
        }
    }
}