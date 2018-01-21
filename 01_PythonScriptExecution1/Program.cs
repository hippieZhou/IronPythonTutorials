using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PythonScriptExecution1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pythonEngin = IronPython.Hosting.Python.CreateEngine();
            var pythonScripts = pythonEngin.CreateScriptSourceFromString("print'hello world'");
            pythonScripts.Execute();
            Console.ReadKey();
        }
    }
}
