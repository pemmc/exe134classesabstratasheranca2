using System;
using Course.Entities;

using System.Collections.Generic;

using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //Classes abstratas (HERANÇA2) - 134
            // https://github.com/pemmc/exe134classesabstratasheranca2

            Console.WriteLine("CLASSE ABSTRATA");
            Console.WriteLine();

            List<Account> minhaLista = new List<Account>();


            minhaLista.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));

            minhaLista.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));

            minhaLista.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));

            minhaLista.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account acc in minhaLista)
            {

                sum += acc.Balance;

            }

            Console.WriteLine("TOTAL BALANCE: R$" + sum.ToString("C", new CultureInfo("pt-BR").NumberFormat));
            Console.WriteLine();

            foreach (Account acc in minhaLista)
            {

                acc.Withdraw(10.0);

                Console.WriteLine("Updated balance for count: "
                    + acc.Number
                    + ": R$"
                    + acc.Balance.ToString("C", new CultureInfo("pt-BR").NumberFormat));


            }
        }
    }
}
