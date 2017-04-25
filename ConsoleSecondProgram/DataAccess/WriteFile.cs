using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleSecondProgram.DataAccess
{
    internal class WriteFile : IDisposable
    {
        public WriteFile(String filename)
        {
            _filename = filename;
        }

        public String _filename { get; set; }
        public StreamWriter _file { get; set; }

        public void Dispose()
        {
            _file.Dispose();
        }

        public void Initialize()
        {
            _file = new StreamWriter(_filename);
        }

        public bool WriteData(List<DBO.Person> e)
        {
            try
            {
                foreach (var item in e)
                {
                    _file.WriteLine(item.Name + ',' + item.Firstname + ',' + item.Address);
                }
                _file.Flush();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}