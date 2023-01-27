﻿namespace AdaCredit.UI.Domain
{
    public sealed class Client
    {
        public string Name { get; set; }
        public long Document { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Account Account { get; set; } = null;
        public Client(string name, long document, string phone, string address)
        {
            Name = name;
            Document = document;
            Phone = phone;
            Address = address;
        }
        public Client(string name, long document, string phone, string address, Account account)
        {
            Name = name;
            Document = document;
            Phone = phone;
            Address = address;
            Account = account;
        }

    }
}