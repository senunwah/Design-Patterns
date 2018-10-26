using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Xpayimpl : IXpay
    {
        private double amount;
        private short cardCVVNo;
        private string cardExpMonth;
        private string cardExpYear;
        private string creditCardNo;
        private string customerName;

        public double GetAmount()
        {
            return amount;
        }

        public short GetCardCVVNo()
        {
            return cardCVVNo;
        }

        public string GetCardExpMonth()
        {
            return cardExpMonth;
        }

        public string GetCardExpYear()
        {
            return cardExpYear;
        }

        public string GetCreditCardNo()
        {
            return creditCardNo;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public void SetAmount(double amount)
        {
            this.amount = amount;
        }

        public void SetCardCVVNo(short cardCVVNo)
        {
            this.cardCVVNo = cardCVVNo;
        }

        public void SetCardExpMonth(string cardExpMonth)
        {
            this.cardExpMonth = cardExpMonth;
        }

        public void SetCardExpYear(string cardExpYear)
        {
            this.cardExpYear = cardExpYear;
        }

        public void SetCreditCardNo(string creditCardNo)
        {
            this.creditCardNo = creditCardNo;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }
    }
}
