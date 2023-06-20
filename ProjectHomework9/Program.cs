using ProjectHomework9;

internal class Program
{
    private static void Main(string[] args)
    {
        // ex:370
        int[] arr = new int[] { 1, 2, 3,4,6,1,4,5,90,76,54,6,7,8,9,6,8,8,8,85,1 };
        NewArrayClass nac = new NewArrayClass(arr);
        nac.getSum();

        Console.ReadKey();
    }
}