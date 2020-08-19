using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_21
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        private int _codan;
        protected int _number_of_seats;

        public Car()
        {

        }
        public Car(string model, string brand, int year, string color, int codan, int number_of_seats)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            _codan = codan;
            _number_of_seats = number_of_seats;
        }
        public int GetCoden()
        {
            return _codan;
        }
        public int GetNumberOfSeats()
        {
            return _number_of_seats;
        }
        protected void CahngeNumberOfSeats(int seats)
        {
            _number_of_seats += seats;
        }

        public override string ToString()
        {
            return "Car Brand: " + Brand + " Car Model: " + Model + " Car Year: " + Year + " Car Color: " + Color;
        }
    }
}
