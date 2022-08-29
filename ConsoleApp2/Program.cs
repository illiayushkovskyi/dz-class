using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Adress
    {
        int index;
        string country;
        string city;
        string street;
        int house;
        int apartaments;

        public int Index
        {
            get
            { return index; }
            set
            { index = value; }
        }
        public string Country
            { get { return country; } set { country = value; } }
        public string City
            { get { return city; } set { city = value; } }
        public string Street
            { get { return street; } set { street = value; } }
        public int House
            { get { return house; } set { house = value; } }
        public int Apartaments
        { get { return apartaments; } set { apartaments = value; } }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Adress adress = new Adress();
                adress.Index = 93458;
                adress.Country = "USA";
                adress.City = "California";
                adress.Street = "Paseo Jacaranda";
                adress.House = 4;
                adress.Apartaments = 7;
            Console.WriteLine("index - " + adress.Index);
            Console.WriteLine("country - " + adress.Country);
            Console.WriteLine("city - " + adress.City);
            Console.WriteLine("street - " + adress.Street);
            Console.WriteLine("House - " + adress.House);
            Console.WriteLine("apartments - " + adress.Apartaments);
            Console.ReadKey();
        }
    }
}
