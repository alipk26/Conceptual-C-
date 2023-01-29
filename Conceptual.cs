using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulConcept
{
    internal class Conceptual
    {
        public static void AsOperator()
        {
            Shape shape = new();
            Circle circle = new();
            Shape? convertToShape = circle as Shape;

            Console.WriteLine($"convertions 'circle as shape' produces {convertToShape}");

            Circle? convertToCircle = shape as Circle;

            if(convertToCircle == null)
            {
                Console.WriteLine($"convertions 'shape as Circle' produces null");
            }
            else
            {
                Console.WriteLine($"convertions 'circle as shape' produces {convertToCircle}");
            }

            

        }
        public static void isOperator()
        {
            Circle circle = new();
            Rectangle rectangle = new();
            Console.WriteLine($"Is circle inherit from shape : {circle is Shape}");
            Console.WriteLine($"Is rectangle inherit from shape : {rectangle is Shape}");
        }

        class Shape { }

        class Circle : Shape { }

        class Rectangle : Shape { }

        public static void PassingByValue(int x)
        {
            x *= 2;
            Console.WriteLine($"Body Passing by value, X value: {x}");
        }

        public static void PassingByReference(ref int x)
        {
            x *= 2;
            Console.WriteLine($"Body PassingValueByRef, Y value: {x}");
        }
        public static void ShowNullable()
        {
            //variable reference type
            string? name = "hello";

            if (name == null) Console.WriteLine("null value");

            //variable value type
            int? age = null;
            if (age.HasValue)
            {
                Console.WriteLine($"age : {age}");
            }
            else
            {
                Console.WriteLine("age has no value");
            }

        }

    }

    internal class Employee
    {

        public const decimal baseSalary = 100_000;
        public readonly int _id = 100;

        public Employee(int id)
        {
            _id = id;
        }

        public int Age { get; set; } = 10;

        public readonly List<int> myNum = new();

        public void AddNum(int num)
        {
            myNum.Add(num);
        }

        public void DisplayNum()
        {
            foreach (var item in myNum)
            {
                 Console.WriteLine($"{item}");
            }
        }
        public static void UpdatePromo(double price, float promo, out decimal totalPrice, out decimal totalDiscount)
        {
            totalPrice = (decimal)((price * (promo / 100)) + price);
            totalDiscount = (decimal)(price - promo);
        }
    }
}
