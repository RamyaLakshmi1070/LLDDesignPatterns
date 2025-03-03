using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class OrderFacade
    {
        Payment payment;
        Product product;
        Invoice invoice;

        public OrderFacade()
        {
            payment = new Payment();
            product = new Product();
            invoice = new Invoice();
        }

        public void MakeOrder()
        {
            Product p = product.GetProduct(102);
            payment.MakePayment();
            invoice.GenerateInvoice();
            Console.WriteLine("Order has been created Successfuly");

        }
    }
}
