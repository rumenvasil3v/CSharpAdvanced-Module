using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuestSet = new HashSet<string>();
            HashSet<string> regularGuestSet = new HashSet<string>();
            HashSet<string> invitedPeople = new HashSet<string>();
            HashSet<string> peopleCameToParty = new HashSet<string>();

            AddingInvitedPeopleToParty(invitedPeople);
            AddingPeopleWhoCameToParty(peopleCameToParty);
            AllocatePeopleWhoDidntCameToParty(invitedPeople, peopleCameToParty, vipGuestSet, regularGuestSet);
           
            int countOfPeopleWhoDidntCame = vipGuestSet.Count + regularGuestSet.Count;
            Console.WriteLine(countOfPeopleWhoDidntCame);

            PrintVipGuestsWhoDidntCame(vipGuestSet);
            PrintRegularGuestsWhoDidntCame(regularGuestSet);
        }

        static void AddingInvitedPeopleToParty(HashSet<string> invitedPeople)
        {
            string command;
            while ((command = Console.ReadLine()) != "PARTY")
            {
                invitedPeople.Add(command);
            }
        }

        static void AddingPeopleWhoCameToParty(HashSet<string> peopleCameToParty)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                peopleCameToParty.Add(command);
            }
        }

        static void AllocatePeopleWhoDidntCameToParty(HashSet<string> invitedPeople, HashSet<string> peopleCameToParty, HashSet<string> vipGuestSet, HashSet<string> regularGuestSet)
        {
            foreach (var person in invitedPeople)
            {
                if (!peopleCameToParty.Contains(person))
                {
                    if (char.IsDigit(person[0]))
                    {
                        vipGuestSet.Add(person);
                    }
                    else
                    {
                        regularGuestSet.Add(person);
                    }
                }
            }
        }

        static void PrintVipGuestsWhoDidntCame(HashSet<string> vipGuestSet)
        {
            foreach (var vipPerson in vipGuestSet)
            {
                Console.WriteLine(vipPerson);
            }
        }

        static void PrintRegularGuestsWhoDidntCame(HashSet<string> regularGuestSet)
        {
            foreach (var regularPerson in regularGuestSet)
            {
                Console.WriteLine(regularPerson);
            }
        }
    }
}
