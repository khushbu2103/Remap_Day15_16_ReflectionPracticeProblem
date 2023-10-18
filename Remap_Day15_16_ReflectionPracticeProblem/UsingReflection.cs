using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day15_16_ReflectionPracticeProblem
{
    public class UsingReflection
    {
        public UsingReflection()
        {
            Console.WriteLine("Hello World");
        }
        public UsingReflection(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public int Number(int a)
        {
            return a * a;
        }
        public static void FindType()
        {
            Type type = typeof(UsingReflection);
            ConstructorInfo con = type.GetConstructor(Type.EmptyTypes);
            UsingReflection nearest = (UsingReflection)con.Invoke(null);
            object numberclassobject = con.Invoke(new object[] { });
            MethodInfo method = type.GetMethod("Number");
            object value = method.Invoke(numberclassobject, new object[] { 20 });
            Console.WriteLine(nearest);
            Console.WriteLine("UsingReflection.Number Returned {0}", value);
        }
        public static void ReflectionTest()
        {
            Type type = typeof(UsingReflection);

            Console.WriteLine("Full name {0} ", type.FullName);

            Console.WriteLine("Class Name {0} ", type.Name);
            Console.WriteLine("Methods In Given Class");

            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + "  " + method.Name);
            }

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + "  " + property.Name);
            }

            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
