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

        public static bool WriteData(List<DBO.Person> e)
        {
            DataAccess.WriteFile writer = new DataAccess.WriteFile("out.csv");
            using (writer)
            {
                writer.Initialize();
                return writer.WriteData(e);
            }
        }
    }
}