
internal class Program
{

    
    private static void Main(string[] args)
    {
        int number = 0;

        number = MethodRef(ref number);
        Console.WriteLine(number);
    }

    private static int MethodRef(ref int number)
    {
        number = 2;
        return 10;
    }
}