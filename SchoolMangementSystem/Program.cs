using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMangementSystem
{
    class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    class Student
    {
        public int id { get; set; }
        public string student_id { get; set; }
        public string student_name { get; set; }
        public string student_gender { get; set; }
        public string student_address { get; set; }
        public string student_grade { get; set; }
        public string student_section { get; set; }
        public string student_status { get; set; }
        public DateTime date_insert { get; set; }
    }

    class Teacher
    {
        public int id { get; set; }
        public string teacher_id { get; set; }
        public string teacher_name { get; set; }
        public string teacher_gender { get; set; }
        public string teacher_address { get; set; }
        public string teacher_status { get; set; }
        public DateTime date_insert { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            List<User> users = new List<User>
            {
                new User { id = 1, username = "admin", password = "admin123" }
            };

            List<Student> students = new List<Student>
            {
                new Student { id = 1, student_id = "S001", student_name = "John Doe", student_gender = "Male", student_address = "123 Oak Street, New York", student_grade = "Grade 6", student_section = "A", student_status = "Enrolled", date_insert = DateTime.Now },
                new Student { id = 2, student_id = "S002", student_name = "Jane Smith", student_gender = "Female", student_address = "456 Maple Street, Los Angeles", student_grade = "Grade 6", student_section = "B", student_status = "Enrolled", date_insert = DateTime.Now },
                new Student { id = 3, student_id = "S003", student_name = "David Johnson", student_gender = "Male", student_address = "789 Pine Avenue, Chicago", student_grade = "Grade 5", student_section = "C", student_status = "Enrolled", date_insert = DateTime.Now },
                new Student { id = 4, student_id = "S004", student_name = "Emily Davis", student_gender = "Female", student_address = "1011 Elm Street, Houston", student_grade = "Grade 5", student_section = "D", student_status = "Enrolled", date_insert = DateTime.Now },
                new Student { id = 5, student_id = "S005", student_name = "Michael Brown", student_gender = "Male", student_address = "1213 Cedar Street, Miami", student_grade = "Grade 4", student_section = "E", student_status = "Graduated", date_insert = DateTime.Now },
                new Student { id = 6, student_id = "S006", student_name = "Sarah Wilson", student_gender = "Female", student_address = "1415 Birch Street, Atlanta", student_grade = "Grade 4", student_section = "A", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 7, student_id = "S007", student_name = "Daniel Martinez", student_gender = "Male", student_address = "1617 Spruce Street, Dallas", student_grade = "Grade 3", student_section = "B", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 8, student_id = "S008", student_name = "Olivia Anderson", student_gender = "Female", student_address = "1819 Walnut Street, Seattle", student_grade = "Grade 3", student_section = "C", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 9, student_id = "S009", student_name = "William Taylor", student_gender = "Male", student_address = "2021 Ash Street, San Francisco", student_grade = "Grade 2", student_section = "D", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 10, student_id = "S010", student_name = "Sophia Thomas", student_gender = "Female", student_address = "2223 Oak Avenue, Boston", student_grade = "Grade 2", student_section = "E", student_status = "Graduated", date_insert = DateTime.Now },
                new Student { id = 11, student_id = "S011", student_name = "Alexander Garcia", student_gender = "Male", student_address = "2425 Pine Street, Philadelphia", student_grade = "Grade 1", student_section = "A", student_status = "Enrolled", date_insert = DateTime.Now },
                new Student { id = 12, student_id = "S012", student_name = "Sophia Martinez", student_gender = "Female", student_address = "2627 Elm Street, Phoenix", student_grade = "Grade 1", student_section = "B", student_status = "Enrolled", date_insert = DateTime.Now },
                new Student { id = 13, student_id = "S013", student_name = "Mason Robinson", student_gender = "Male", student_address = "2829 Cedar Street, San Antonio", student_grade = "Grade 2", student_section = "C", student_status = "Enrolled", date_insert = DateTime.Now },
                new Student { id = 14, student_id = "S014", student_name = "Amelia Clark", student_gender = "Female", student_address = "3031 Birch Street, San Diego", student_grade = "Grade 2", student_section = "D", student_status = "Enrolled", date_insert = DateTime.Now },
                new Student { id = 15, student_id = "S015", student_name = "Ethan Rodriguez", student_gender = "Male", student_address = "3233 Spruce Street, San Jose", student_grade = "Grade 3", student_section = "E", student_status = "Graduated", date_insert = DateTime.Now },
                new Student { id = 16, student_id = "S016", student_name = "Isabella Hernandez", student_gender = "Female", student_address = "3435 Walnut Street, Austin", student_grade = "Grade 3", student_section = "A", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 17, student_id = "S017", student_name = "Aiden Lopez", student_gender = "Male", student_address = "3637 Ash Street, Jacksonville", student_grade = "Grade 4", student_section = "B", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 18, student_id = "S018", student_name = "Mia Gonzalez", student_gender = "Female", student_address = "3839 Oak Avenue, Fort Worth", student_grade = "Grade 4", student_section = "C", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 19, student_id = "S019", student_name = "Lucas Perez", student_gender = "Male", student_address = "4041 Pine Street, Columbus", student_grade = "Grade 5", student_section = "D", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 20, student_id = "S020", student_name = "Zoe Rivera", student_gender = "Female", student_address = "4243 Elm Street, Charlotte", student_grade = "Grade 5", student_section = "E", student_status = "Graduated", date_insert = DateTime.Now },
                new Student { id = 21, student_id = "S021", student_name = "Jackson Lee", student_gender = "Male", student_address = "4445 Cedar Street, Indianapolis", student_grade = "Grade 6", student_section = "A", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 22, student_id = "S022", student_name = "Charlotte Walker", student_gender = "Female", student_address = "4647 Birch Street, San Francisco", student_grade = "Grade 6", student_section = "B", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 23, student_id = "S023", student_name = "Gabriel Hall", student_gender = "Male", student_address = "4849 Spruce Street, Seattle", student_grade = "Grade 1", student_section = "C", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 24, student_id = "S024", student_name = "Lily Young", student_gender = "Female", student_address = "5051 Walnut Street, Denver", student_grade = "Grade 1", student_section = "D", student_status = "Pending", date_insert = DateTime.Now },
                new Student { id = 25, student_id = "S025", student_name = "Logan White", student_gender = "Male", student_address = "5253 Ash Street, Washington", student_grade = "Grade 2", student_section = "E", student_status = "Graduated", date_insert = DateTime.Now }
            };

            // Création des enseignants
            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher { id = 1, teacher_id = "T001", teacher_name = "Mary Johnson", teacher_gender = "Female", teacher_address = "123 Oak Street, New York", teacher_status = "Active", date_insert = DateTime.Now },
                new Teacher { id = 2, teacher_id = "T002", teacher_name = "James Smith", teacher_gender = "Male", teacher_address = "456 Maple Street, Los Angeles", teacher_status = "Active", date_insert = DateTime.Now },
                new Teacher { id = 3, teacher_id = "T003", teacher_name = "Patricia Williams", teacher_gender = "Female", teacher_address = "789 Pine Avenue, Chicago", teacher_status = "Active", date_insert = DateTime.Now },
                new Teacher { id = 4, teacher_id = "T004", teacher_name = "John Brown", teacher_gender = "Male", teacher_address = "1011 Elm Street, Houston", teacher_status = "Active", date_insert = DateTime.Now },
                new Teacher { id = 5, teacher_id = "T005", teacher_name = "Jennifer Jones", teacher_gender = "Female", teacher_address = "1213 Cedar Street, Miami", teacher_status = "Active", date_insert = DateTime.Now },
                new Teacher { id = 6, teacher_id = "T006", teacher_name = "Michael Davis", teacher_gender = "Male", teacher_address = "1415 Birch Street, Atlanta", teacher_status = "Active", date_insert = DateTime.Now },
                new Teacher { id = 7, teacher_id = "T007", teacher_name = "Linda Wilson", teacher_gender = "Female", teacher_address = "1617 Spruce Street, Dallas", teacher_status = "Active", date_insert = DateTime.Now },
                new Teacher { id = 8, teacher_id = "T008", teacher_name = "William Moore", teacher_gender = "Male", teacher_address = "1819 Walnut Street, Seattle", teacher_status = "Active", date_insert = DateTime.Now },
                new Teacher { id = 9, teacher_id = "T009", teacher_name = "Elizabeth Taylor", teacher_gender = "Female", teacher_address = "2021 Ash Street, San Francisco", teacher_status = "Active", date_insert = DateTime.Now },
                new Teacher { id = 10, teacher_id = "T010", teacher_name = "David Anderson", teacher_gender = "Male", teacher_address = "2223 Oak Avenue, Boston", teacher_status = "Active", date_insert = DateTime.Now }
            };
        }
    }
}
