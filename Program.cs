namespace GenericsAssignment
{
    public class Program
    {
        public static void Main(string []args)
        {
            Console.WriteLine("Wellcome to Generics Problem");

            //int output = MaximumNumber.MaximumIntegerNumber(40, 50, 60);
            //Console.WriteLine(output);

            float floatoutput = MaximumNumber.MaximumFloatsNumber(1.6f, 2.2f, 1.3f);
            Console.WriteLine(floatoutput);

            //double doubleoutput = MaximumNumber.MaximumDoubleNumber(111.2, 22.45, 78.56);
            //Console.WriteLine(doubleoutput);

            //string strigoutput = MaximumNumber.MaximumStringNumber("Apple", "Peach", "Banana");
            //Console.WriteLine(strigoutput);
        }
    }
}

