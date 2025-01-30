using System.Reflection;
using System.Reflection.Metadata;

namespace ReflectionDemo
{
    internal partial class Program
    {
        public static class ReflectionHelper
        {
            public static void LaunchChosenMethodFromConsole(object item)
            {
                Type type = item.GetType();
                MethodInfo[] allMethods = type.GetMethods();
                PropertyInfo[] allProperties = type.GetProperties();

                var methodNames = allMethods.Select(m => m.Name).Where(n => !n.StartsWith("get") && !n.StartsWith("set")).ToArray();

                var methodsNotObject = methodNames.Take(methodNames.Length - 4).ToArray();

                Console.WriteLine("Which Method do you like to run?");

                for (int i = 0; i < methodsNotObject.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {methodsNotObject[i]}");
                }
                int chosenMethodIndex = int.Parse(Console.ReadLine()) - 1;//1
                string chosenMethodName = methodsNotObject[chosenMethodIndex];//Bark

                MethodInfo targetedMethod = allMethods.FirstOrDefault(m => m.Name == chosenMethodName); //1 br metod 
                var parametersForMethod = new object[0];
                targetedMethod.Invoke(item, parametersForMethod);
            }

            public static T CreateInstance<T>(string message)
            {
                Console.WriteLine(message);
                Type type = typeof(T);
                var constructors = type.GetConstructors();
                ConstructorInfo constFd = type.GetConstructors()
                   .FirstOrDefault(c => c.CustomAttributes.Any(at => at.AttributeType.Name == "BestForAutoCrationAttribute"));
                if (constFd == null)
                {
                    Console.WriteLine("Sorry no construr supports auto fill console option!");
                    return default(T);
                }
                var parameters = constFd.GetParameters();               
                List<object> paramData = new List<object>();
                foreach (ParameterInfo param in parameters)
                {
                    Console.Write($"{param.Name.ToUpper()} [{param.ParameterType.Name}] = ");
                    string input = Console.ReadLine(); //
                    var parsedParam = Convert.ChangeType(input, param.ParameterType);
                    paramData.Add(parsedParam);
                }
                object result = constFd.Invoke(paramData.ToArray());
                return (T)result;
            }
        }
    }
}