//A bank account has a holder name (first name, middle name and last name), available 
//amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated 
//with the account. Declare the variables needed to keep the information for a single 
//bank account using the appropriate data types and descriptive names.

using System;

class BankAccountSystem
{
    static void Main()
    {
        //Example data filled up

        string holderFirstName = "Ivan";
        string holderSurname = "Petrov";
        string holderFamily = "Ivanov";

        decimal holderBalance = 56.4526M;

        string bankName = "BestBank";
        string holderIBAN = "GB29 NWBK 6016 1331 9268 19";
        string holderBIC = "123456";
        ulong holderCARD1, holderCARD2, holderCARD3;
        holderCARD1 = 41699100012345678;

        Console.WriteLine(holderCARD1);
    }
}
