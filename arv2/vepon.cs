using System;


public class vepon
{

    public string Name { get; set; }
    protected int Damage { get; set; } = 100 ;



    public virtual void Attack(Personer target)
    {

        Console.WriteLine("attack!");
        target.Hitpoints -= Damage;

    }    
}
