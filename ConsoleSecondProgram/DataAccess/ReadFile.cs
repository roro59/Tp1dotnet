using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleSecondProgram.DataAccess
{
  public class ReadFile : IDisposable
  {
    public String file
    {
      get;
      set;
    }

    public StreamReader stream
    {
      get;
      set;
    }


    public ReadFile(String name)
    {
      this.file = file;
    }

    public void Initialize()
    {
      stream = new StreamReader(file);
    }

    public void Dispose()
    {
      stream.Dispose();
    }

    public List<DBO.Person> ReadData()
    {
      List<DBO.Person> res = new List<DBO.Person>();
      String s;
      String[] elt;
      do
      {
        s = stream.ReadLine();
        elt = s.Split(';');
        res.Add(new DBO.Person(elt[0], elt[1], elt[2]));
      } while (!stream.EndOfStream);

      return res;
    }
  }
}
