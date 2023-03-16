using Banksystem;

BankAccount user = new BankAccount();
bool repeat = true;

while (repeat == true)
{
    Console.WriteLine("""
        Velkommen til din bank konto
        Hvad vil du gøre?
        1. Se hvor mange penge der er på kontoen 
        2. sæt penge ind på kontoen
        3. tag penge ud af kontoen
        """);
    if(int.TryParse(Console.ReadLine(), out int valg))
    {
        switch (valg)
        {
            case 0:
                repeat = false;
                break;

            case 1:
                user.GetBalance();
                break;

            case 2:
                user.Deposit();
                break;

            case 3:
                user.Withdraw();
                break;

        }
    }
}
