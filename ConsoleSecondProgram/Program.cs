using System;
using System.Collections.Generic;

namespace ConsoleSecondProgram
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      List<DBO.Person> res = new List<DBO.Person>();
      BusinessManagement.Person.ReadData(args[0]);
    }
  }
}
