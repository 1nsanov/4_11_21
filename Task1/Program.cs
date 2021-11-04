using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var notebook = new Notebook("Тетрадь 1", 37);
            Console.WriteLine(notebook.OutputToString());
            Console.WriteLine(notebook.ToString());

            Console.WriteLine();
            var generalNotebook = new GeneralNotebook("Твердая", "Тетрадь 2", 37);
            Console.WriteLine(generalNotebook.OutputToString());
            Console.WriteLine(generalNotebook.ToString());

            Console.ReadLine();
        }
    }
}
