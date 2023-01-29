using UsefulConcept;

internal class Program
{
    private static void Main(string[] args)
    {
        var emp = new Employee(101);
        Console.WriteLine($"{emp._id}");
        emp.Age = 25;
        decimal totalPrice, totalDiscount;
        emp.AddNum(10);
        emp.AddNum(11);
        emp.AddNum(12);

        emp.DisplayNum();
        //Employee.UpdatePromo(50_000,1000,out totalPrice,out totalDiscount)  ;
        //Console.WriteLine($"Total Price {totalPrice}");
        //Console.WriteLine($"Total Discount {totalDiscount}");


        //Conceptual.isOperator();
        //Conceptual.AsOperator();

        //Console.WriteLine("Hello, World!");
        //Conceptual.ShowNullable();

        //int x = 10; //immutable
        //Conceptual.PassingByValue(x);
        //Console.WriteLine($"Final Value X: {x}");

        //int y = 10; //nonImmutable
        //Conceptual.PassingByReference(ref y);
        //Console.WriteLine($"Final Value Y: {y}");
    }
}