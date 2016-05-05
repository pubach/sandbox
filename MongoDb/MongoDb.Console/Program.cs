using System;
using System.IO;
using pu.dataBase.mongoDb;

namespace pu.DataBase.MongoDb.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int programRunCount = GetProgramRunCout();
            System.Console.WriteLine("Running...");
            Console.WriteLine("({0})", programRunCount);
            
            
            
            //var class1 = new TestClass();


            System.Console.ReadLine();

        }

        private static int GetProgramRunCout()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\data\\runcount.data";
            if (File.Exists(path))
            {
                var file = File.OpenRead(path);
                var firstByte = file.ReadByte();
                file.Close();
                file = File.OpenWrite(path);
                file.WriteByte((byte)++firstByte);
                file.Close();
                return firstByte;
            }
            else
            {
                var file = File.OpenWrite(path);
                file.WriteByte(1);
                file.Close();
                return 1;

            }
        }
    }
}
