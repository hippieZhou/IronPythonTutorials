using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PythonScriptExecution5
{
    class Program
    {
        static void Main(string[] args)
        {
            var pythonEngin = IronPython.Hosting.Python.CreateEngine();
            var pythonScript = pythonEngin.CreateScriptSourceFromString(
                "helloWorldString='Hello World!'\n" + 
                "print(helloWorldString) \n" + 
                "print(extrnalString)");

            var scope = pythonEngin.CreateScope();
            scope.SetVariable("extrnalString", "How are you.");
            pythonScript.Execute(scope);
            Console.WriteLine();
            Console.WriteLine("List of variables in the scope:");
            foreach (var name in scope.GetVariableNames())
            {
                Console.Write(name+ "   ");
            }
            Console.WriteLine();
            Console.WriteLine("Variable values:");
            Console.WriteLine("helloWorldString:" + scope.GetVariable("helloWorldString"));
            Console.WriteLine("extrnalString:" + scope.GetVariable("extrnalString"));

            Console.ReadKey();
        }
    }
}
