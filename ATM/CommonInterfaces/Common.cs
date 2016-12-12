namespace CommonInterfaces
{
    public interface IWithDraw
    {
    }

    public interface IDeposit
    {
    }

    public interface IBalanceEnquiry
    {
    }

    public interface IAccount
    {
        IWithDraw WithDraw();
        IDeposit Deposit();
        IBalanceEnquiry Balance();
    }
}
