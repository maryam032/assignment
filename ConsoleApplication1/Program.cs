using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        string name;
        string studentId;
        string sem;
        string cgpa;
        string dept;
        string university;
        string attendance;
        //Properties

        public string _atteandance
        {
            get
            {
                return attendance;
            }
            set
            {
                attendance = value;
            }
        }
        public string _Id
        {
            set
            {
                studentId = value;
            }
            get
            {
                return studentId;
            }
        }
        public string _name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string _sem
        {
            set
            {
                sem = value;
            }
            get
            {
                return sem;
            }
        }
        public string _uni
        {
            set
            {
                university = value;
            }
            get
            {
                return university;
            }
        }
        public string _cgpa
        {
            set
            {
                cgpa = value;
            }
            get
            {
                return cgpa;
            }
        }
        public string _dep
        {
            set
            {
                dept = value;
            }
            get
            {
                return dept;
            }
        }
        public
           void addStudent()
        {
            Console.Clear();
            Console.WriteLine("Enter the ID of the student : ");
            studentId = Console.ReadLine();
            Console.WriteLine("Enter the name of the student : ");
            name = (Console.ReadLine());
            Console.WriteLine("Enter the semester of the student : ");
            sem = Console.ReadLine();
            Console.WriteLine("Enter the cgpaof the student : ");
            cgpa = Console.ReadLine();
            Console.WriteLine("Enter the department of the student : ");
            dept = (Console.ReadLine());
            Console.WriteLine("Enter the University of the student : ");
            university = (Console.ReadLine());
            attendance = "0";

            string[] write = { studentId.ToString(), name, cgpa.ToString(), dept, university, sem.ToString(), attendance.ToString() };
            File.WriteAllLines("Data.txt", write);

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int choice;
            int count = 0;
            string ch = "y";
            
            while (ch != "N" || ch != "n")
            {
                Console.Clear();
                Console.WriteLine("Press 1 to Create student profile ");
                Console.WriteLine("Press 2 to Search student");
                Console.WriteLine("Press 3 to Delete student record ");
                Console.WriteLine("Press 4 to list the top 03 of class ");
                Console.WriteLine("Press 4 to Mark Attendance");
                Console.WriteLine("Press 6 to View Attendance");
                Console.WriteLine("Enter Your Choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                Student[] obj = new Student[40];
                if (choice == 1)
                {
                    obj[count] = new Student();
                    obj[count].addStudent();
                    count++;
                }
                if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("1 Search Students  By ID");
                    Console.WriteLine("2 Search Students  By Name");
                    Console.WriteLine("3 List All Students");

                    int opt;

                    opt = Convert.ToInt32(Console.ReadLine());

                    if (opt == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter ID : ");
                        string id = Console.ReadLine();
                        string[] data = File.ReadAllLines("Data.txt");

                        int totalStudents = data.Length / 7;
                        int tempO = data.Length;
                        Student[] readObj = new Student[totalStudents];

                        Console.WriteLine("ID \tName\tCGPA\tDepartment\tUniversity\tSemester\n\n\n");
                        int tempCount = 0;
                        for (int i = 0; i < totalStudents && tempCount != tempO;i++)
                        {
                            
                                 readObj[i] = new Student();
                                readObj[i]._Id =data[tempCount];
                                tempCount++;
                                readObj[i]._name = data[tempCount];
                                tempCount++;
                                readObj[i]._cgpa = data[tempCount];
                                tempCount++;
                                readObj[i]._dep = data[tempCount];
                                tempCount++;
                                readObj[i]._uni = data[tempCount];
                                tempCount++;
                                readObj[i]._sem = data[tempCount];
                                tempCount++;
                                readObj[i]._atteandance = data[tempCount];
                                tempCount++;
                                
                            
                        }
                        for (int i = 0; i < totalStudents; i++)
                        {
                            if(id==readObj[i]._Id)
                            {
                                Console.Write(readObj[i]._Id + "\t");

                                Console.Write(readObj[i]._name + "\t");

                                Console.Write(readObj[i]._cgpa + "\t");

                                Console.Write(readObj[i]._dep + "\t\t");

                                Console.Write(readObj[i]._uni + "\t\t");

                                Console.Write(readObj[i]._sem + "\t\t");

                                Console.WriteLine("\n");
                            }
                        }

                    }
                    else if (opt == 2)
                    {

                        Console.Clear();
                        Console.WriteLine("Enter Name : ");
                        string name = Console.ReadLine();
                        string[] data = File.ReadAllLines("Data.txt");

                        int totalStudents = data.Length / 7;
                        int tempO = data.Length;
                        Student[] readObj = new Student[totalStudents];

                        Console.WriteLine("ID \tName\tCGPA\tDepartment\tUniversity\tSemester\n\n\n");
                        int tempCount = 0;
                        for (int i = 0; i < totalStudents && tempCount != tempO; i++)
                        {

                            readObj[i] = new Student();
                            readObj[i]._Id = data[tempCount];
                            tempCount++;
                            readObj[i]._name = data[tempCount];
                            tempCount++;
                            readObj[i]._cgpa = data[tempCount];
                            tempCount++;
                            readObj[i]._dep = data[tempCount];
                            tempCount++;
                            readObj[i]._uni = data[tempCount];
                            tempCount++;
                            readObj[i]._sem = data[tempCount];
                            tempCount++;
                            readObj[i]._atteandance = data[tempCount];
                            tempCount++;


                        }
                        for (int i = 0; i < totalStudents; i++)
                        {
                            if (name == readObj[i]._name)
                            {
                                Console.Write(readObj[i]._Id + "\t");

                                Console.Write(readObj[i]._name + "\t");

                                Console.Write(readObj[i]._cgpa + "\t");

                                Console.Write(readObj[i]._dep + "\t\t");

                                Console.Write(readObj[i]._uni + "\t\t");

                                Console.Write(readObj[i]._sem + "\t\t");

                                Console.WriteLine("\n");
                            }

                        }
                    }
                    else if(opt == 3)
                    {

                        string[] data = File.ReadAllLines("Data.txt");

                        int totalStudents = data.Length / 7;
                        int tempO = data.Length;
                        Student[] readObj = new Student[totalStudents];

                        Console.WriteLine("ID \tName\tCGPA\tDepartment\tUniversity\tSemester\tAttendance\n\n\n");
                        int tempCount = 0;
                        for (int i = 0; i < totalStudents && tempCount != tempO; i++)
                        {
                            
                            Console.Write(data[tempCount] + "\t");
                            tempCount++;
                            Console.Write(data[tempCount] + "\t");
                            tempCount++;
                            Console.Write(data[tempCount] + "\t");
                            tempCount++;
                            Console.Write(data[tempCount] + "\t\t");
                            tempCount++;
                            Console.Write(data[tempCount] + "\t\t");
                            tempCount++;
                            Console.Write(data[tempCount] + "\t\t");
                            tempCount++;
                            Console.Write(data[tempCount] + "\t");
                            tempCount++;
                            Console.WriteLine("\n");

                        }
                    }

                }
                if (choice == 3)
                {

                }
                if (choice == 4)
                {

                }
                if (choice == 5)
                {

                }
                if (choice == 6)
                {
                    Console.Clear();
                    
                    string[] data = File.ReadAllLines("Data.txt");

                    int totalStudents = data.Length / 7;
                    int tempO = data.Length;
                    Student[] readObj = new Student[totalStudents];

                    Console.WriteLine("ID \tName\tAttendance\n\n\n");
                    int tempCount = 0;
                    for (int i = 0; i < totalStudents && tempCount != tempO; i++)
                    {

                        readObj[i] = new Student();
                        readObj[i]._Id = data[tempCount];
                        tempCount++;
                        readObj[i]._name = data[tempCount];
                        tempCount++;
                        readObj[i]._cgpa = data[tempCount];
                        tempCount++;
                        readObj[i]._dep = data[tempCount];
                        tempCount++;
                        readObj[i]._uni = data[tempCount];
                        tempCount++;
                        readObj[i]._sem = data[tempCount];
                        tempCount++;
                        readObj[i]._atteandance = data[tempCount];
                        tempCount++;


                    }
                    for (int i = 0; i < totalStudents; i++)
                    {
                       
                            Console.Write(readObj[i]._Id + "\t");

                            Console.Write(readObj[i]._name + "\t");

                        

                        if(readObj[i]._atteandance == "0")
                        {
                            Console.Write("Absent");
                        }
                        else
                        {
                            Console.Write("Present");
                        }
                            Console.WriteLine("\n");
                    }
                }
                Console.WriteLine("Press N to Quit or any other key to continue");
                ch = (Console.ReadLine());
                Console.ReadKey();
            }

        }

    }
}
