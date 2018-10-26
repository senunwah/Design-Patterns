using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IXpay xpay = new Xpayimpl();
            xpay.SetCreditCardNo("4789565874102365");
            xpay.SetCustomerName("Enunwah Stephen Temofe");
            xpay.SetCardExpMonth("09");
            xpay.SetCardExpYear("25");
            xpay.SetCardCVVNo((short)235);
            xpay.SetAmount(2565.23);

            IPayD payd = new XpayToPayDAdapter(xpay);
            TestPay(payd);

            Console.ReadLine();
        }

        private static void TestPay(IPayD payd)
        {
            Console.WriteLine(payd.getCardOwnerName());
            Console.WriteLine(payd.getCustCardNo());
            Console.WriteLine(payd.getCardExpMonthDate());
            Console.WriteLine(payd.getCVVNo());
            Console.WriteLine(payd.getTotalAmount());
        }
    }
}
