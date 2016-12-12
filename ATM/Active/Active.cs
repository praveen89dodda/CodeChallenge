using System;
using CommonInterfaces;

namespace Active
{
    public class WithDrawFromActiveAccount : IWithDraw
    {
        public WithDrawFromActiveAccount()
        {
            Console.WriteLine("true");
            Console.WriteLine("Active");
        }
    }

    public class DepositIntoActiveAccount : IDeposit
    {
        public DepositIntoActiveAccount()
        {
            Console.WriteLine("true");
            Console.WriteLine("Active");
        }
    }

    public class BalanceInActiveAccount : IBalanceEnquiry
    {
        public BalanceInActiveAccount()
        {
            Console.WriteLine("true");
            Console.WriteLine("Active");
        }
    }

    public class Active:IAccount
    {
        public IWithDraw WithDraw()
        {
            WithDrawFromActiveAccount obj = new WithDrawFromActiveAccount();
            return obj;
        }

        public IDeposit Deposit()
        {
            DepositIntoActiveAccount obj = new DepositIntoActiveAccount();
            return obj;
        }

        public IBalanceEnquiry Balance()
        {
            BalanceInActiveAccount obj = new BalanceInActiveAccount();
            return obj;
        }
    }
}
