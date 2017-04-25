using System.Collections.Generic;

namespace ConsoleSecondProgram
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            List<DBO.Person> res = new List<DBO.Person>();
            res = BusinessManagement.Person.ReadData(args[0]);
            /*       foreach (var item in res)
                   {
                       Console.WriteLine("name: " + item.Name + " prenom: " + item.Firstname + " address: " + item.Address);
                   }
                   Console.ReadLine();*/
        }
    }
}