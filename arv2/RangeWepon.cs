using System;



public class RangeWepon : vepon
{
    public int Range { get; set; } = 100;


    public RangeWepon()
    
    
    {
 
     Damage = 40;

    }

public override void Attack(Personer target)
{

    Console.WriteLine("Range Attack!");

Random generator = new Random();
target.Hitpoints -= generator.Next(Damage);


}




}
