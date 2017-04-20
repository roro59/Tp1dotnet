using System;
using System.Collections.Generic;

namespace ConsoleSecondProgram.BusinessManagement
{
  public static class Person
  {
    public static List<DBO.Person> ReadData(string filename)
    {

      using (DataAccess.ReadFile reader = new DataAccess.ReadFile(filename))
      {
        reader.Initialize();
        return reader.ReadData();
      }
    }
  }
}
