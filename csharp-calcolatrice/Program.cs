namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int i1= -1; int i2=2; int i3=3; int i4 = -1;
            double d1 = - 3.5; double d2=2.3;

            //Testate tutti i metodi della vostra classe di helper(con un esempio per ogni casistica).

            Console.WriteLine($"somma int: {CalcoliHelper.sum(i1, i2)}");
            Console.WriteLine($"somma double: {CalcoliHelper.sum(d1, d2)}");

            Console.WriteLine($"differenza int: {CalcoliHelper.diff(i1, i2)}");
            Console.WriteLine($"differenza double: {CalcoliHelper.diff(d1, d2)}");

            Console.WriteLine($"moltiplicazione int: {CalcoliHelper.mult(i1, i2)}");
            Console.WriteLine($"moltiplicazione double: {CalcoliHelper.mult(d1, d2)}");

            Console.WriteLine($"v assoluto int: {i1.abs()}");
            Console.WriteLine($"v assoluto double: {d1.abs()}");

            Console.WriteLine($"minimo int: {CalcoliHelper.min(i1, i2)}");
            Console.WriteLine($"minimo double: {CalcoliHelper.min(d1, d2)}");

            Console.WriteLine($"max int: {CalcoliHelper.max(i1, i2)}");
            Console.WriteLine($"max double: {CalcoliHelper.max(d1, d2)}");

            Console.WriteLine($"potenza di {i2}^ {i3} = {i2.pow(i3)}");
            Console.WriteLine($"potenza di {i2}^ {i4} = {i2.pow(i4)}");
        }
    }
}