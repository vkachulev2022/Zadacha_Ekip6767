namespace Zadachaekip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadArray();
            int[] sorted = SortArray(numbers, true);
            SaveToJson(sorted);

            Console.WriteLine("Масивът е сортиран и записан в JSON файл.");
        }
    }
}
