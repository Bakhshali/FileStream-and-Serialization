using FileStream_and_Serialization_Practice.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace FileStream_and_Serialization_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Directory,File,StreamWrite,StreamReader
            string GaleryPath = @"C:\Users\Ali\Desktop\Galery";
            string PrivatePath = @"C:\Users\Ali\Desktop\PrivateFolder";

            string FolderPath = Path.Combine(GaleryPath, "Family");
            string FolderPath1 = Path.Combine(PrivatePath, "Private");
            string filepathTXT = Path.Combine(FolderPath, "family.txt");
            string anotherFile = Path.Combine(FolderPath, "galery.txt");
            string baxseliPrivate = Path.Combine(FolderPath1, "Baxseliprivate.txt");
            string videosPath = Path.Combine(FolderPath1, "videos.txt");

            string Foldertxt1 = Path.Combine(@"C:\Users\Ali\Desktop\Galery", "menu.txt");
            string Foldertxt2 = Path.Combine(@"C:\Users\Ali\Desktop\PrivateFolder", "phoneNumber.txt");

            //StreamWriter streamWriter = new StreamWriter(filepathTXT,true);
            //streamWriter.Write("Shir hemishe shirdi");
            //streamWriter.Write("Menim qerdesim");
            //streamWriter.Write("Hele saat ");
            //streamWriter.Write("11 di"); 
            //streamWriter.Write("menim qerdeshim");

            //streamWriter.Close();

            //StreamReader streamReader = new StreamReader(filepathTXT);

            //string data = streamReader.ReadToEnd();
            //Console.WriteLine(data);

            //streamReader.Close();


            //using (StreamWriter streamWriter = new StreamWriter(filepathTXT,true))
            //{
            //    streamWriter.Write("Hele saat ");
            //    streamWriter.Write("11 di");
            //    streamWriter.Write("menim qerdeshim");
            //}
            //using (StreamReader streamReader = new StreamReader(filepathTXT))

            //{
            //    string data = streamReader.ReadToEnd();
            //    Console.WriteLine(data);
            //}



            //Directory.CreateDirectory(FolderPath);
            //Directory.CreateDirectory(FolderPath1);
            //File.Create(filepathTXT);
            //File.Create(anotherFile);
            //File.Create(baxseliPrivate);
            //File.Create(videosPath);

            //File.Create(Foldertxt1);
            //File.Create(Foldertxt2);

            //Console.WriteLine("Folders");
            //foreach (var item in Directory.GetDirectories(GaleryPath))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\nFiles");
            //foreach (var item in Directory.GetFiles(FolderPath1))
            //{
            //    Console.WriteLine(item);
            //}

            //File.Delete(FolderPath1);
            //File.Delete(FolderPath);


            //Directory.Delete(path);


            //if (File.Exists(filePath))
            //{
            //    File.Delete(filePath);
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir file yoxdur");
            //}
            #endregion


            #region Serialization
            Computers computers = new Computers { ID = 1, Brand = "Acer", Ram = "8GB", GraphicCar = "RTX2090", Price = 2850.90 };
            Computers computers2 = new Computers { ID = 2, Brand = "MacBook", Ram = "32GB", GraphicCar = "M1Pro", Price = 5000.20 };
            Computers computers3 = new Computers { ID = 3, Brand = "ASUS", Ram = "16GB", GraphicCar = "RTX3090", Price = 3200.80 };
            Computers computers4 = new Computers { ID = 4, Brand = "HP", Ram = "2GB", GraphicCar = "RYzen 7", Price = 1569.90 };


            OrderItem orderItem = new OrderItem { Id = 1, Computer = computers, Price = computers.Price };
            OrderItem orderItem2 = new OrderItem { Id = 2, Computer = computers2, Price = computers2.Price };
            OrderItem orderItem3 = new OrderItem { Id = 3, Computer = computers3, Price = computers3.Price };
            OrderItem orderItem4 = new OrderItem { Id = 4, Computer = computers4, Price = computers4.Price };

            Order order = new Order()
            {
                Id = 1,
                OrderItems = new List<OrderItem>()
                {
                    orderItem,
                    orderItem2,
                    orderItem3,
                    orderItem4
                },
                TotalPrice = 11800.30
            };
            
            var orderStr = JsonConvert.SerializeObject(order);
            Console.WriteLine(orderStr);


            #endregion
        }

    }
}
