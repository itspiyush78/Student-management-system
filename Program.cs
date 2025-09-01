using System;
public class students
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public int[]? Marks { get; set; }
    public int Total { get; set; }
    public int Average { get; set; }
    public int Percentage { get; set; }
    public string Grade { get; set; }
    
    public void Calculate()
    {
        Total = 0;
        foreach (var Mark in  Marks)
        {
            Total += Mark;
        }
        Average = Total / Marks.Length;
        Percentage = Total * 100 / 300;

        if (Average >= 90) Grade = "A";
        else if (Average >= 75) Grade = "B";
        else if (Average >= 50) Grade = "C";
        else Grade = "Fail";

    }
    public static void Main()
    {
        List<students> studentList = new List<students>();
        bool running = true;
        while (running)     
        {
            Console.WriteLine("----- Student Management System -------");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show all students");
            Console.WriteLine("3. Exit");

            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());




            switch (choice)
            {
                case 1:
                    Console.Write("Enter Student Name: ");
                    string name = (Console.ReadLine());
                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    int[] marks = new int[3];
                    Console.WriteLine("Enter Marks in 3 subjects: ");
                    for (int i = 0; i < 3; i++)
                    {
                        marks[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    students s = new students()
                    {
                        Name = name,
                        Age = age,
                        Marks = marks
                    };
                    s.Calculate();
                    studentList.Add(s);

                    Console.WriteLine("Student added Successfully!");
                    break;
                case 2:
                    {
                        Console.WriteLine("\n---- Student Record ----");
                        if (studentList.Count == 0)
                        {
                            Console.WriteLine("No student found");
                        }
                        else
                        {
                            Console.WriteLine("Name\tAge\tTotal\tAvg\t%\tGrade");
                            foreach (var st in studentList)
                            {
                                Console.WriteLine($"{st.Name}\t{st.Age}\t{st.Total}\t{st.Average}\t{st.Percentage}\t{st.Grade}");
                            }
                        }
                        break;
                    }
                case 3:
                    running = false;
                    Console.WriteLine("Exiting program... Good Bye!");
                    break;
                default:
                    Console.WriteLine("Invaild option ");
                    break;


            }
        }
    
        Console.ReadKey();
    }
}