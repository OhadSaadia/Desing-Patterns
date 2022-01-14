using System;
using System.Text.Json;

namespace DesingPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserting Data:
            Customer customer = new Customer("David","Levi","311144635");
            Invoice invoice = new Invoice(145.33,10.2f, DateTime.Now, customer);

            //Prototype Pattern Copy:
            Invoice invoiceCopy = invoice.Clone();

            //Json Serialize Copy
            Invoice invoiceDeapCopy = DeapCopy<Invoice>(invoice);

            //Changing Values In First Invoice
            invoice.VAT = 2.0f;

            //Print First Invoice 
            Console.WriteLine("First Invoice:---------------------------------------------");
            Console.WriteLine(invoice);
            Console.WriteLine();

            //Print Prototype Pattern Copy 
            Console.WriteLine("Prototype Pattern Copy Invoice:------------------------------------");
            Console.WriteLine(invoiceCopy);
            Console.WriteLine();


            //Print Json Serialize Copy 
            Console.WriteLine("Json Serialize Copy Invoice:---------------------------------------");
            Console.WriteLine(invoiceDeapCopy);
            Console.WriteLine();


        }
        public static T DeapCopy<T>(T self)
        {
            var json = JsonSerializer.Serialize(self);
            T obj = JsonSerializer.Deserialize<T>(json);
            return obj;
        }
    }
}
