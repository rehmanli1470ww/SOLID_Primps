#region OCP_Befor
//Calculation calculation = new Calculation();
//calculation.GetSpeed("On foot");
//
//
//class Person
//{
//
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Age { get; set; }
//
//    public Person(string name, string surname, int age)
//    {
//        Name = name;
//        Surname = surname;
//        Age = age;
//    }
//}
//
//class Calculation
//{
//    public Person ?person { get; set; }
//    public string Type = default;
//
//    public void SetSpeed(string type)
//    {
//        Type=type;
//    }
//
//    public double GetSpeed(string type)
//    {
//        if (type== "On foot")
//        {
//            Console.WriteLine("Teyinat noqtesine piyada 1 saata "+4.5 +" km yol gedecek");
//            return 4.5;
//        }
//        else if (type == "running away")
//        {
//            Console.WriteLine("Teyinat noqtesine qacaraq 1 saata " +  8 + " km yol gedecek ");
//            return 8;
//        }
//        else if (type == "Bicycle")
//        {
//            Console.WriteLine("Teyinat noqtesine velosiped ile 1 saata " + 12 + " km yol gedecek");
//            return 12;
//        }
//        return 0;
//    }
//}

#endregion 

#region OCP_After

//Calculation calculation = new Calculation();
//calculation.Type = new RunningAway();
//Console.WriteLine(" 1 saata " + calculation.Type.ToString()+" " + calculation.GetSpeed()+ " km yol qet ede bilecek");
//class Person
//{
//
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Age { get; set; }
//
//    public Person(string name, string surname, int age)
//    {
//        Name = name;
//        Surname = surname;
//        Age = age;
//    }
//}
//
//
//interface IType
//{
//    decimal getCalculation();
//}
//
//class RunningAway : IType
//{
//    public decimal getCalculation()
//    {
//        return 8m;
//    }
//}
//
//class Bicycle : IType
//{
//    public decimal getCalculation()
//    {
//        return 12m;
//    }
//}
//
//class Calculation
//{
//    public Person? person { get; set; }
//    public IType Type = default;
//
//    public void SetSpeed(IType type)
//    {
//        Type = type;
//    }
//
//    public decimal GetSpeed()
//    {
//        return Type.getCalculation();
//    }
//
//}

#endregion 



