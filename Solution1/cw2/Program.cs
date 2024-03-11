class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        int[] tbl = { 1, 2, 3, 4, 5 };
        
        int sum = 0;
        foreach (int num in tbl)
        {
            sum += num;
        }
    }
    //zad1
    int AvrageOfArray(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum / arr.Length;
    }
}