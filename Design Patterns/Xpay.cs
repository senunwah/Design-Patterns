using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    interface IXpay
    {
        string GetCreditCardNo();
        string GetCustomerName();
        string GetCardExpMonth();
        string GetCardExpYear();
        short GetCardCVVNo();
        double GetAmount();
        void SetCreditCardNo(string creditCardNo);
        void SetCustomerName(string customerName);
        void SetCardExpMonth(string cardExpMonth);
        void SetCardExpYear(string cardExpYear);
        void SetCardCVVNo(short cardCVVNo);
        void SetAmount(double amount);
    }
}
