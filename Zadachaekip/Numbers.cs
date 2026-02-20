using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachaekip
{
    public static int[] ReadArrayFromConsole()
    {
        Console.WriteLine("Въведете числа, разделени с интервал:");
        string input = Console.ReadLine();

        int[] numbers = input
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        return numbers;
    }
}
