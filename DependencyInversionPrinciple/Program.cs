#region DIP_Befor

//class Person
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public string DrivingLicense { get; set; }
//}
//
//class Car
//{
//    public string Marka { get; set; }
//    public string Model { get; set; }
//    public int Years{ get; set; }
//    Person Driver { get; set; }
//
//    public Car(Person driver,string marka, string model, int years)
//    {
//        Marka = marka;
//        Model = model;
//        Years = years;
//        Driver = driver;
//    }
//}

#endregion


#region DIP_After

//class Person
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public string DrivingLicense { get; set; }
//}
//
//class Car
//{
//    public string Marka { get; set; }
//    public string Model { get; set; }
//    public int Years { get; set; }
//    
//
//    public Car(string marka, string model, int years)
//    {
//        Marka = marka;
//        Model = model;
//        Years = years;
//    }
//
//    public void ShowDriver(Person Driver)
//    {
//        Console.WriteLine("Name :"+Driver.Name+"\nSurname :"+Driver.Surname+ "\nDriving License :"+Driver.DrivingLicense);
//    }
//}
#endregion
