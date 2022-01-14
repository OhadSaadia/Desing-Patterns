using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype
{
    class Invoice : IProto<Invoice>
    {
        public Invoice(double finalPrice, float vAT, DateTime dealDate, Customer customer)
        {
            FinalPrice = finalPrice;
            VAT = vAT;
            DealDate = dealDate;
            Customer = customer;
        }

        public double FinalPrice { get; set; }
        public float VAT { get; set; }

        public DateTime DealDate { get; set; }

        public Customer Customer { get; set; }

        public override string ToString()
        {
            return $"Customer Name: {Customer.FirstName} {Customer.LastName}\n" +
                $"Deal Date: {DealDate.Date}\nFinal Price: {FinalPrice}\nVAT: {VAT}";
        }

        public Invoice Clone()
        {
            Invoice newInvoice = new Invoice(FinalPrice, VAT, DealDate.Date, Customer.Clone());
            return newInvoice;
        }
    }
}
