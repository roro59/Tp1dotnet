using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleSecondProgram.DataAccess
{
    public class ReadFile : IDisposable
    {
        public String _filename
        {
            get;
            set;
        }

        public StreamReader _file
        {
            get;
            set;
        }

        public ReadFile(String name)
        {
            this._filename = name;
        }

        public void Initialize()
        {
            _file = new StreamReader(_filename);
        }

        public void Dispose()
        {
            _file.Dispose();
        }

        public List<DBO.Person> ReadData()
        {
            List<DBO.Person> res = new List<DBO.Person>();
            String s;
            String[] elt;
            try
            {
                do
                {
                    s = _file.ReadLine();
                    elt = s.Split(',');
                    res.Add(new DBO.Person(elt[0], elt[1], elt[2]));
                } while (!_file.EndOfStream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur durant la lecture" + e.Message);
                throw;
            }

            return res;
        }
    }
}