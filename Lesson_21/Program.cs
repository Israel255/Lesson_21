using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car honda = new Car("Civic", "Honda", 2010, "Gray", 8520, 5);
            XmlSerializer car_xml = new XmlSerializer(typeof(Car));
            //using (Stream file = new FileStream(@"C:\Users\USER\Desktop\עבודות\Lesson 21\car.xml", FileMode.Create))
            //{
              // car_xml.Serialize(file, honda);
            //}
            Car honda_civic;
            using (Stream file = new FileStream(@"C:\Users\USER\Desktop\עבודות\Lesson 21\car.xml", FileMode.Open))
            {
                honda_civic = car_xml.Deserialize(file) as Car;
            }
            Console.WriteLine(honda_civic);

          //  Car[] cars =
            //{
              //  new Car ("Corolla","Toyota",2007,"Blue",4645,5),
                //new Car ("Ibiza","Seat",2010,"Silver",1614,4),
                //new Car ("Cx5","Mazda",2012,"Black",7913,7)
            //};
            XmlSerializer cars_xml = new XmlSerializer(typeof(Car[]));
            //using (Stream cars_file = new FileStream(@"C:\Users\USER\Desktop\עבודות\Lesson 21\cars.xml",FileMode.Create))
            //{
            //  cars_xml.Serialize(cars_file, cars);
            //}
            Car[] cars_israel;
            using (Stream cars_file = new FileStream(@"C:\Users\USER\Desktop\עבודות\Lesson 21\cars.xml", FileMode.Open))
            {
                cars_israel = cars_xml.Deserialize(cars_file) as Car[];
            }
            foreach (Car c in cars_israel)
            {
                Console.WriteLine(c);
            }
        }
    }
}
