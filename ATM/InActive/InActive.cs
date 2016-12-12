using System;
using CommonInterfaces;

namespace InActive
{
    public class WithDrawFromInActiveAccount : IWithDraw
    {
        public WithDrawFromInActiveAccount()
        {
            Console.WriteLine("false");
            Console.WriteLine("InActive");
        }
    }

    public class DepositIntoInActiveAccount : IDeposit
    {
        public DepositIntoInActiveAccount()
        {
            Console.WriteLine("false");
            Console.WriteLine("InActive");
        }
    }

    public class BalanceInInActiveAccount : IBalanceEnquiry
    {
        public BalanceInInActiveAccount()
        {
            Console.WriteLine("false");
            Console.WriteLine("InActive");
        }
    }

    public class InActive:IAccount
    {
        public IWithDraw WithDraw()
        {
            WithDrawFromInActiveAccount obj = new WithDrawFromInActiveAccount();
            return obj;
        }

        public IDeposit Deposit()
        {
            DepositIntoInActiveAccount obj = new DepositIntoInActiveAccount();
            return obj;
        }

        public IBalanceEnquiry Balance()
        {
            BalanceInInActiveAccount obj = new BalanceInInActiveAccount();
            return obj;
        }
    }
}
