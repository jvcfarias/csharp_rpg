namespace src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou magia super efetiva com bônus de  " + Bonus;
            } else {
                return this.Name + " Lançou uma magia com força fraca com bônus de  " + Bonus;
            }
            
        }
    }
}