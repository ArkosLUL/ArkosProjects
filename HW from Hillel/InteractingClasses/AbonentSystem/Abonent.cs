using System;
using System.Collections.Generic;
using System.Text;

namespace AbonentSystem
{
    class Abonent
    {
        private long idNumber;
        private string lastName;
        private string firstName;
        private string patronymic;
        private string address;
        private long creditCard;
        private double debet;
        private double credit;
        private DateTime longDistanceConversationTime;
        private DateTime urbanConversationTime;

        public long IdNumber { get => idNumber; private set => idNumber = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public string FirstName { get => firstName; private set => firstName = value; }
        public string Patronymic { get => patronymic; private set => patronymic = value; }
        public string Address { get => address; private set => address = value; }
        public long CreditCard { get => creditCard; private set => creditCard = value; }
        public double Debet { get => debet; private set => debet = value; }
        public double Credit { get => credit; private set => credit = value; }
        public DateTime LongDistanceConversationTime { get => longDistanceConversationTime; private set => longDistanceConversationTime = value; }
        public DateTime UrbanConversationTime { get => urbanConversationTime; private set => urbanConversationTime = value; }

        public Abonent(long idnumber, string lastname, string firstname, string patronymic, string address, long creditcard, double debet, double credit, TimeSpan longdistanceconversationtime, TimeSpan urbanconversationtime)
        {
            SetAtributes(idnumber, lastname, firstname, patronymic, address, creditcard, debet, credit, longdistanceconversationtime, urbanconversationtime);
        }

        private void SetAtributes(long idnumber, string lastname, string firstname, string patronymic, string address, long creditcard, double debet, double credit, TimeSpan longdistanceconversationtime, TimeSpan urbanconversationtime)
        {
            IdNumber = idnumber;
            LastName = lastname;
            FirstName = firstname;
            Patronymic = patronymic;
            Address = address;
            CreditCard = creditcard;
            Debet = debet;
            Credit = credit;
            LongDistanceConversationTime = LongDistanceConversationTime.Add(longdistanceconversationtime);
            UrbanConversationTime = UrbanConversationTime.Add(urbanconversationtime);
        }

        public override string ToString()
        {
            return string.Format($"{IdNumber}, {LastName}, {FirstName}, {Patronymic}, {Address}, {CreditCard}, {Debet}, {Credit}, {LongDistanceConversationTime.ToLongTimeString()}, {UrbanConversationTime.ToLongTimeString()}");
        }
    }
}
