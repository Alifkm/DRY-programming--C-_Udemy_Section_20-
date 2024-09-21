namespace DRY_Dont_t_Repeat_Yourself
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemberPaymentCalculator MemberPaymentCalculator = new MemberPaymentCalculator();
            
            double regularMemberPayment = MemberPaymentCalculator.CalculateDiscount(MemberType.Regular, 1200);
            Console.WriteLine(regularMemberPayment);

            double privateMemberPayment = MemberPaymentCalculator.CalculateDiscount(MemberType.Private, 2000);
            Console.WriteLine(privateMemberPayment);

            double premiumMemberPayment = MemberPaymentCalculator.CalculateDiscount(MemberType.Premium, 800);
            Console.WriteLine(premiumMemberPayment);

            double goldMemberPayment = MemberPaymentCalculator.CalculateDiscount(MemberType.Gold, 1000);
            Console.WriteLine(goldMemberPayment);

            double platinumMemberPayment = MemberPaymentCalculator.CalculateDiscount(MemberType.Platinum, 5000);
            Console.WriteLine(platinumMemberPayment);

        }
    }
}