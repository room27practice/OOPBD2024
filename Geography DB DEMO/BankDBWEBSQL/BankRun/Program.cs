﻿using BankRun.Models;
using Microsoft.EntityFrameworkCore;

namespace BankRun
{
    internal class Program
    {
        static void Main()
        {
            CreateMultipleAccountHoldersWithConsole();

            Thread.Sleep(2000);

            Console.WriteLine("Choose Action [1 List All Member Details]\n[2 Edit Members Info]\n[3 Manage User Balances]");
            int actionChoise = int.Parse(Console.ReadLine());
            switch (actionChoise)
            {
                case 1:
                    {
                        ListAllMembersInfoData();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Members info edit was not yet implemented");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Members account balances management was not yet implemented");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choise option number!");
                    }
                    break;
            }

        }

        private static void ListAllMembersInfoData()
        {
            Console.WriteLine("Listing All Account Holders and their Accounts");
            AccountHolder[] holders = null;

            using (var db = new BankDBContext())
            {
                holders = db.AccountHolders.Include(h => h.Accounts).ToArray();
            }

            foreach (var h in holders)
            {
                string data = h.GetInfo();
                Console.WriteLine(data);
                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }

        private static void CreateMultipleAccountHoldersWithConsole()
        {
            Console.WriteLine("Do you like to create new AccountHolders Y/N");
            string command = Console.ReadLine();
            while (command.ToLower().StartsWith('y'))
            {
                IndividualAccountIntercationCreate();
                Console.WriteLine("Do you like to create new AccountHolders Y/N");
                command = Console.ReadLine();
            }
        }

        private static void IndividualAccountIntercationCreate()
        {
            Console.WriteLine("--Create NEW BANK Holder--");
            Console.WriteLine();

            Console.WriteLine("Input Holder FirstName:");
            string f_name = Console.ReadLine();
            Console.WriteLine("Input Holder LastName:");
            string l_name = Console.ReadLine();

            Console.WriteLine("Input Holder SSN:");
            string ssn = Console.ReadLine();

            AccountHolder newAccountHolder = new AccountHolder(f_name, l_name, ssn);
            newAccountHolder.Accounts = CreateAccountBalances();

            using (var db = new BankDBContext())
            {
                db.AccountHolders.Add(newAccountHolder);
                db.SaveChanges();
            }
        }

        private static List<Account> CreateAccountBalances()
        {
            List<Account> accountsOfHolder = new List<Account>();

            Console.WriteLine("Type all account banalces, or type End to finish!");

            while (true)
            {
                string input = Console.ReadLine(); //баланс или End
                if (input.ToLower() == "end")
                {
                    break;
                }
                var newAccount = new Account(decimal.Parse(input));
                accountsOfHolder.Add(newAccount);
            }

            return accountsOfHolder;
        }
    }
}