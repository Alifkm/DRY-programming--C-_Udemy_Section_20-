using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY_Dont_t_Repeat_Yourself
{
    public enum MemberType
    {
        Regular,
        Private,
        Premium,
        Gold,
        Platinum
    }
    public class MemberPaymentCalculator
    {
        private const int PAYMENT_THRESHOLD = 1000;

        public double CalculateDiscount(MemberType memberType, double money)
        {
            double payment = 0;

            switch(memberType)
            {
                case MemberType.Regular:
                    payment = money > PAYMENT_THRESHOLD ? 0.1 : 0.05;
                    break;
                case MemberType.Private:
                    payment = money > PAYMENT_THRESHOLD ? 0.2 : 0.15;
                    break;
                case MemberType.Premium:
                    payment = money > PAYMENT_THRESHOLD ? 0.3 : 0.25;
                    break;
                case MemberType.Gold:
                    payment = money > PAYMENT_THRESHOLD ? 0.4 : 0.35;
                    break;
                case MemberType.Platinum:
                    payment = money > PAYMENT_THRESHOLD ? 0.5 : 0.45;
                    break;
            }

            return payment * money;
        }
    }
}
