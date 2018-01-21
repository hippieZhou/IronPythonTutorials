using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PythonScriptExecution2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pythonEngin = IronPython.Hosting.Python.CreateEngine();
            var pythonScripts = pythonEngin.CreateScriptSourceFromFile("..\\..\\HelloWorld.py");
            pythonScripts.Execute();
            Console.ReadKey();
        }
    }
}
