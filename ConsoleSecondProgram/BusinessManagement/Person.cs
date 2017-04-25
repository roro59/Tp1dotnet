using System;
using System.Collections.Generic;

namespace ConsoleSecondProgram.BusinessManagement
{
  public static class Person
  {
    public static List<DBO.Person> ReadData(string filename)
    {
            DataAccess.ReadFile reader = new DataAccess.ReadFile(filename);  
      using (reader)
      {
        reader.Initialize();
        return reader.ReadData();
      }
    }
  }
}
