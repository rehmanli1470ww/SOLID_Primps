#region LSP_Befor

Print print=new Print();
Teacher teacher = new("t", "t", "dd", "23");
Student teeacher = new(2,"t", "t", "dd", "23");
print.Show(teeacher);

class Teacher
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Age { get; set; }
    public string Experience { get; set; }

    public Teacher(string name, string surname, string age, string experience)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Experience = experience;
    }

    public virtual string DailyChart()
    {
        
        return "8 saat yatmaq 8 saat istirahet 8 saat islemek";
    }
}

class Student: Teacher
{
    public int LessonTime { get; set; }
    public Student(int lessonTime,string name, string surname, string age, string experience) : base(name, surname, age, experience)
    {
        LessonTime= lessonTime;

    }

    public  override string DailyChart()
    {
        return "8 saat yatmaq 4 saat istirahet 12 saat islemek";
    }

}

class Print
{
   
    public void Show(Teacher teacher)
    {
        Console.WriteLine("Name :"+ teacher.Name+"\nSurname :"+ teacher.Surname+"\nAge :"+ teacher.Age+ "\nExperience :"+ teacher.Experience);
    }
}


#endregion

#region LSP_After

#endregion