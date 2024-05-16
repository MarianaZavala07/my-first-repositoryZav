internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Person person1=new Person();
        {
          
        }
          Console.WriteLine(person1.name);
        


        person1.birthday= new DateOnly(2000,07,07);

        person1.monthlySalary=10000;

       Console.WriteLine(person1.name);
       Console.WriteLine(person1.birthday.ToString());
       Console.WriteLine(person1.monthlySalary.ToString());
       Console.WriteLine(person1.annualSalaries.ToString());
        
    }
}
     public class Person
{
    public string name { get; set; }
    public DateOnly birthday { get; set; }
    public decimal monthlySalary { get; set; }
    
    public decimal annualSalaries 
    { 
        get
        { 
            return monthlySalary * 12;
        }
    }
    public decimal annualSalary()
    {
      return monthlySalary * 12;
    }
    public void walking (int steps)
    {
       Console.WriteLine ("You are Walking" + steps);
    }
}

