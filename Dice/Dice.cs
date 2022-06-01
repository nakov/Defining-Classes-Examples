using System;

class AnotherDice
{
    //private int _sides;
    //public int Sides { 
    //    get { return _sides; }
    //    set { _sides = value }
    //}

    public int Sides { get; set; }

    private int speed;

    public int Speed
    {
        get { return speed; }
        private set { speed = value; }
    }

    public int Speed2 { get; set; }



    private Random rnd = new Random();

    public int Roll()
    {
        this.Speed = 500;
        int num = 1 + rnd.Next(Sides);
        return num;
    }

    
}

class MainClass
{
    static void Main()
    {
        String str = new String('a', 50);



        AnotherDice d6 = new AnotherDice();
        //int x = d6.rnd.Next();
        d6.Sides = 6;
        for (int i = 0; i < 10; i++)
        {
            int num = d6.Roll();
            Console.WriteLine(num);
        }
    }
}
