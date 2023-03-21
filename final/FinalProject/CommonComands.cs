using static System.Console;

class CommonComands
{
    string AccountNumber;
    public string GetAccountNumber(List<string> AccountData)
    {
        AccountNumber = AccountData[0];
        return AccountNumber;
    }
}