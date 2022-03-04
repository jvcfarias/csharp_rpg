using src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Knight arus = new Knight ("Arus", 23, "Knight");
        Wizard wizard = new Wizard ("Jennica", 23, "White Wizard");
        Console.WriteLine(wizard.Attack(7));
        Console.WriteLine(wizard.Attack(1));

    }
    
    public virtual string Attack(){
        return this.Name + " Atacou com a sua espada";
    }
}