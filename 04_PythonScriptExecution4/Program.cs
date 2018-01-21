using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PythonScriptExecution4
{
    class Program
    {
        static void Main(string[] args)
        {
            var pythonEngin = IronPython.Hosting.Python.CreateEngine();
            Console.WriteLine("Search paths:");
            var searchPaths = pythonEngin.GetSearchPaths();
            foreach (var path in searchPaths)
            {
                Console.WriteLine(path);
            }
            Console.WriteLine();

            searchPaths.Add("..\\..\\Lib");
            pythonEngin.SetSearchPaths(searchPaths);

            var pythonScript = pythonEngin.CreateScriptSourceFromFile("..\\..\\HelloWorldBase64.py");
            pythonScript.Execute();

            Console.ReadKey();
        }
    }
}
