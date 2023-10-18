using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
            Student[] std = new Student[4];


            for (int i = 0; i < std.Length; i++)
            {

                std[i].Id = i;
                Console.WriteLine(std[i].Id + ",");

                std[i].Name = "Name " + i.ToString();
                Console.Write(std[i].Name + ",");

                std[i].Address = "Address of student ";
                Console.Write(std[i].Address + ",");


                std[i].dataOfBirth = Convert.ToDateTime("2012-12-06 02:26:46");
                Console.Write(std[i].dataOfBirth);




                Console.ReadLine();


            }
            

        }
    }
}
