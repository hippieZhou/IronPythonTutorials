using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PythonScriptExecution6
{
    class Program
    {
        static void Main(string[] args)
        {
            var pythonEngin = IronPython.Hosting.Python.CreateEngine();
            var searchPaths = pythonEngin.GetSearchPaths();
            searchPaths.Add("..\\..");
            pythonEngin.SetSearchPaths(searchPaths);

            var scope = IronPython.Hosting.Python.ImportModule(pythonEngin, "HelloWorldModule");

            dynamic printHelloWorldFunction = scope.GetVariable("PrintHelloWorld");
            printHelloWorldFunction();

            dynamic printMessageFunction = scope.GetVariable("PrintMessage");
            printMessageFunction("GoodBye!");

            dynamic addFunction = scope.GetVariable("Add");
            Console.WriteLine("The sum of 1 and 2 is " + addFunction(1,2));

            Console.ReadKey();
        }
    }
}
