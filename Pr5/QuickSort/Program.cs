namespace Program;

class Program2
{
    public static void Main()
    {
        var array = new int[] { 4,6,7,2,3,1,5,7 };
        var sorter = new QuickSort();
        var sortedArray = sorter.Sort(array, (a, b) => b - a);

        foreach (var item in sortedArray)
        {
            Console.WriteLine(item);
        }
    }
}