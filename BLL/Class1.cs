using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace BLL
{
    public class Class1 {
        static string dbFile = "data.txt";

    public static void Main(string[] args)
    {
        CategoryList categorys;
        if (File.Exists(dbFile))
        {
            try
            {
                categorys = SerializedReaderWriter.Read<CategoryList>(dbFile);

                    foreach (var category in categorys)
                {
                    Console.WriteLine(category.Categorys);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            categorys = new CategoryList {
                    ///Här ska vi mata in strings från GUI
                };
            try
            {
                SerializedReaderWriter.Write<CategoryList>(dbFile, categorys);
            }
            catch (Exception e)
            {
                Console.WriteLine("Serialization failed!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
}
