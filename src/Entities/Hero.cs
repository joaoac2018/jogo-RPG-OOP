namespace src.Entities
{
    public abstract class Hero
    {
        public string Name; 
        public int level; 
        public string heroType;

        public Hero(string Name,int level, string heroType)
        {
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
        }

        public Hero()
        {

        }
        
        public override string ToString()
        {
            return this.Name+ " " + this.level + " " + this.heroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }
    }
}