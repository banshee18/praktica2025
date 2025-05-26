using System;
using System.Numerics;
using PhoneLibrary;

class Program
{
    static void Main()
    {
        Phone myPhone = new Phone("Apple", "iPhone 15", "+375291234567");
        myPhone.ShowInfo();
        myPhone.MakeCall("+375297654321");
    }
}
