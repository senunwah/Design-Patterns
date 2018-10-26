using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    interface IPayD
    {
        string getCustCardNo();
        string getCardOwnerName();
        string getCardExpMonthDate();
        int getCVVNo();
        double getTotalAmount();
        void setCustCardNo(string custCardNo);
        void setCardOwnerName(string cardOwnerName);
        void setCardExpMonthDate(string cardExpMonthDate);
        void setCVVNo(int cVVNo);
        void setTotalAmount(double totalAmount);

    }
}
