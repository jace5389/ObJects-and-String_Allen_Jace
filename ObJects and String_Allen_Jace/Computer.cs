using System;
using System.Collections.Generic;
using System.Text;

namespace ObJects_and_String_Allen_Jace
{
    // IsOn, Brand, and TYpe get set
    class Computer : IBootUP
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }
        // Computer booting up and shutting down
        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if(IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }
        // Computer is made by Brand and is Type is on IsOn
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is on:{IsOn}!";
        }
    }
}