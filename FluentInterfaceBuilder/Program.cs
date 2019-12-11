﻿using System;

namespace FluentInterfaceBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client.Builder()
            .FirstName("Slawomir")
            .LastName("Kowalski")
            .ZipCode("34 174")
            .MyWallet(456.32)
            .HomeNumber(23)
            .Town("Cambridge")
            .Street("botolph lane")
            .build();

            Console.WriteLine("Data client: " + "\nFirstName: " + client.FirstName +
                "\nKowalski: " + client.LastName +
                "\nZip code: " + client.ZipCode +
                "\nWallet: " + client.MyWallet +
                "\nHome number: " + client.HomeNumber +
                "\nTown: " + client.Town +
                "\nStreet: " + client.Street);

            Console.ReadKey();
        }
    }
}
