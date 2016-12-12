using System;
using Active;
using CommonInterfaces;
using InActive;
using InOperative;

namespace CommonMethods
{
    public class Account
    {
        public static IAccount GetAccount(string accountType)
        {
            if (string.Equals(accountType, "active", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Active.Active();
            }
            else if (string.Equals(accountType, "inactive", StringComparison.InvariantCultureIgnoreCase))
            {
                return  new InActive.InActive();
            }
            else if (string.Equals(accountType, "in-operative", StringComparison.InvariantCultureIgnoreCase))
            {
                return  new InOperative.InOperative();
            }
            else
            {
                return null;
            }
        }
    }
}
