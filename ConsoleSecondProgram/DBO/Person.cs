using System;
namespace ConsoleSecondProgram.DBO
{
  public class Person
  {
    public String Address
    {
      get;
      set;
    }

    public String Firstname
    {
      get;
      set;
    }

    public String Name
    {
      get;
      set;
    }

    public Person()
    {
    }
    public Person(String name, String firstname, String address)
    {
      this.Address = address;
      this.Name = name;
      this.Firstname = firstname;
       
    }
  }
}
