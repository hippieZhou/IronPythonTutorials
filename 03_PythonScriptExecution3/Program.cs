using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PythonScriptExecution3
{
    class Program
    {
        static void Main(string[] args)
        {
            var pythonEngin = IronPython.Hosting.Python.CreateEngine();
            Console.WriteLine("Search Paths:");
            var searchPaths = pythonEngin.GetSearchPaths();
            foreach (var item in searchPaths)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            searchPaths.Add("..\\..");
            pythonEngin.SetSearchPaths(searchPaths);

            var pythonScript = pythonEngin.CreateScriptSourceFromFile("..\\..\\HelloWorld.py");
            pythonScript.Execute();

            Console.ReadKey();
        }
    }
}
