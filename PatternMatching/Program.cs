using static System.Console;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {

            object[] objects = { null, 10, new Dog("Rex", 3), new Animal(3), new Dog("Spot", 3), "something" };

            foreach (var obj in objects)
            {
                ClassicalTypeChecking(obj);

                PatternMatching(obj);
            }

            //PrintStars("some string");

            ReadKey();
        }

        private static void PatternMatching(object obj)
        {
            switch (obj)
            {
                case Dog d when d.Name == "Rex":
                    WriteLine($"{d.GetType()} with age:{d.Age} and name:REX");
                    break;

                case Dog d:
                    WriteLine($"{d.GetType()} with age:{d.Age} and name:{d.Name}");
                    break;

                case int i:
                    WriteLine($"{i.GetType()} with value:{i}");
                    break;

                case Animal a:
                    WriteLine($"{a.GetType()} with age:{a.Age}");
                    break;

                case null:
                    WriteLine("<null>");
                    break;

                default:
                    WriteLine($"<other object> {obj.GetType()}");
                    break;
            }
        }

        private static void ClassicalTypeChecking(object obj)
        {
            if (obj is Animal)
            {
                var d = obj as Dog;
                if (d == null)
                {
                    WriteLine($"{obj.GetType()} with age:{(obj as Animal).Age}");
                }
                else if (d.Name == "Rex")
                {
                    WriteLine($"{obj.GetType()} with age:{(obj as Dog).Age} and name:REX");
                }
                else
                {
                    WriteLine($"{obj.GetType()} with age:{(obj as Dog).Age} and name:{(obj as Dog).Name}");
                }
            }
            else if (obj is int)
            {
                WriteLine($"{obj.GetType()} with value:{obj}");
            }
            else if (obj is null)
            {
                WriteLine("<null>");
            }
            else
            {
                WriteLine("<other>");
            }
        }

        private static void PrintStars(object o)
        {
            if (o is null) return;     // constant pattern "null"

            if (o is var x)
            {
                WriteLine($"it's a var pattern with the type {x?.GetType()?.Name}");
            }

            if (!(o is int i)) return; // type pattern "int i"

            WriteLine(new string('*', i));
        }
    }

    public class Animal
    {
        public int Age { get; set; }

        public Animal(int age)
        {
            Age = age;
        }
    }

    public class Dog : Animal
    {
        public string Name { get; set; }

        public Dog(string name, int age) : base(age)
        {
            Name = name;
        }
    }
}
