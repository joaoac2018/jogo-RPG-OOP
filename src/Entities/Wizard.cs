namespace src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string heroType)
        {
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
            
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Lançou magia com de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
        }     
    }
}