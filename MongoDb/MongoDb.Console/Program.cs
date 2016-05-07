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
            
            
            
<<<<<<< HEAD
            var class1 = new TestClass();
            
=======
            //var class1 = new TestClass();

>>>>>>> 29b6cce5dcb1e225210a7473a972a40bb9716f9f

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
