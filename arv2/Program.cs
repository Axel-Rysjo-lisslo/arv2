God Ben = new God();


//Gun agun = new Gun();
//agun.Attack(Ben);


List<vepon> awepon = new();

awepon.Add(new Gun());
awepon.Add(new Kniv());

foreach(vepon w in awepon)
{

Console.WriteLine(w.Name);
if (w is Gun)
{


Console.WriteLine("Its empty!");

}

}

Console.ReadLine();
