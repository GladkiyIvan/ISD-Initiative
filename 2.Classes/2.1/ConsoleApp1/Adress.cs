using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Adress
    {
        string index;
        string country;
        string city;
        string street;
        int house;
        int apartment;

        public string Index
        { get { return index; } set { index = value; } }
        public string Country
        { get { return country; } set { country = value; } }
        public string City
        { get { return city; } set { city = value; } }
        public string Street
        { get { return street; } set { street = value; } }
        public int House
        { get { return house; } set { house = value; } }
        public int Apartment
        { get { return apartment; } set { apartment = value; } }

        public void output()
        {
            Console.WriteLine("Index: " + index + "\nCountry: " + country + "\nCity: " + city + "\nStreet: " + street + "\nHouse: " + house + "\nApartment: " + apartment);
        }

    }
}
