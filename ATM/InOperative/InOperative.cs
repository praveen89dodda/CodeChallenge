using System;
using CommonInterfaces;

namespace InOperative
{
    public class WithDrawFromInOperativeAccount : IWithDraw
    {
        public WithDrawFromInOperativeAccount()
        {
            Console.WriteLine("true");
            Console.WriteLine("Active");
        }
    }

    public class DepositIntoInOperativeAccount : IDeposit
    {
        public DepositIntoInOperativeAccount()
        {
            Console.WriteLine("true");
            Console.WriteLine("Active");
        }
    }

    public class BalanceInInOperativeAccount : IBalanceEnquiry
    {
        public BalanceInInOperativeAccount()
        {
            Console.WriteLine("true");
            Console.WriteLine("Active");
        }
    }

    public class InOperative : IAccount
    {
        public IWithDraw WithDraw()
        {
            WithDrawFromInOperativeAccount obj = new WithDrawFromInOperativeAccount();
            return obj;
        }

        public IDeposit Deposit()
        {
            DepositIntoInOperativeAccount obj = new DepositIntoInOperativeAccount();
            return obj;
        }

        public IBalanceEnquiry Balance()
        {
            BalanceInInOperativeAccount obj = new BalanceInInOperativeAccount();
            return obj;
        }
    }
}
