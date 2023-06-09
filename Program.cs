using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Tarixi daxil edin:  ");
                string date = Console.ReadLine();
                var cevrilmisFormat = DateTime.ParseExact(date, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                Console.WriteLine(cevrilmisFormat);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
           
        }
    }
}