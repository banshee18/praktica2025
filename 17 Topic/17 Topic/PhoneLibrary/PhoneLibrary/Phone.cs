using System;

namespace PhoneLibrary
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }

        public Phone(string brand, string model, string number)
        {
            Brand = brand;
            Model = model;
            Number = number;
        }

        public void MakeCall(string targetNumber)
        {
            Console.WriteLine($"Звонок с {Number} на {targetNumber}...");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Телефон: {Brand} {Model}, Номер: {Number}");
        }
    }
}
