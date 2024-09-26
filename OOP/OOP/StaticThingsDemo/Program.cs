namespace StaticThingsDemo
{
    internal class Program
    {
        static void Main()
        {
            var students = new List<Student>()
        {
            new Student{Name="Alexander",Grade=11},
            new Student{Name="Djan",Grade=11},
            new Student{Name="Viktor",Grade=11},
            new Student{Name="Daniel",Grade=11},
            new Student{Name="Martin",Grade=10},
            new Student{Name="Simo",Grade=12},
        };

            var st1 = new Student();
            st1.Name = "Mihail";
            st1.Grade = 9;
            st1.Name = "Mihail Mihailov";

            students[0].Name = "Alexandur Derivolkov";



            foreach (var st in students)
            {
                st.SayHello();
                Console.WriteLine(new string('=', 20));

            }

            Student.SchoolName = "PGMETT-Hristo Botev Shumen in Preslav 51 street";
            students[0].TownName = "Varna";

            st1.SayHello();

            foreach (var st in students)
            {
                st.SayHello();
                Console.WriteLine(new string('=', 20));
            }

            Student.DoMagic();
        }
    }
    public class Student
    {
        public static string SchoolName { get; set; } = "PGMETT-Shumen";
        public string TownName { get; set; } = "Shumen";
        public string Name { get; set; }
        public int Grade { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello.I am from {TownName} town. I am {Name} from {Grade} grade.And we all study in {SchoolName}");
        }

        public static void DoMagic()
        {
            Console.WriteLine($"The school is {SchoolName}");
        }

    }



}