using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class XpayToPayDAdapter : IPayD
    {

        private string CardExpMonthDate;
        private string CardOwnerName;
        private string CustomerCardNo;
        private int CVVNo;
        private double TotalAmount;


        private IXpay xpay;

        public XpayToPayDAdapter(IXpay xpay)
        {
            this.xpay = xpay;
            SetProp();
        }

        private void SetProp()
        {
            setCardExpMonthDate(xpay.GetCardExpMonth() + xpay.GetCardExpYear());
            setCardOwnerName(xpay.GetCustomerName());
            setCustCardNo(xpay.GetCreditCardNo());
            setCVVNo(xpay.GetCardCVVNo());
            setTotalAmount(xpay.GetAmount());        
        }

        public string getCardExpMonthDate()
        {
            return CardExpMonthDate;
        }

        public string getCardOwnerName()
        {
            return CardOwnerName;
        }

        public string getCustCardNo()
        {
            return CustomerCardNo;
        }

        public int getCVVNo()
        {
            return CVVNo;
        }

        public double getTotalAmount()
        {
            return TotalAmount;
        }

        public void setCardExpMonthDate(string cardExpMonthDate)
        {
            this.CardExpMonthDate = cardExpMonthDate;
        }

        public void setCardOwnerName(string cardOwnerName)
        {
            this.CardOwnerName = cardOwnerName;
        }

        public void setCustCardNo(string custCardNo)
        {
            this.CustomerCardNo = custCardNo;
        }

        public void setCVVNo(int cVVNo)
        {
            this.CVVNo = cVVNo;
        }

        public void setTotalAmount(double totalAmount)
        {
            this.TotalAmount = totalAmount;
        }
    }
}
