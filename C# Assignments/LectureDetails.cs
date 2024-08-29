/* Que 3.Define a class to represent lecture details. Include the following members and the program should handle at least details of 5 lecturer.
 Data members
 Name of the lecturer
 Name of the subject
 Name ofcourse
 Numberof lecturers
 Data functions
 To assign initial values
 To add lecture details
 To display name and lecture details */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureDetails
{
    public class Lecture
    {
        public string LecturerName;
        public string SubjectName;
        public string CourseName;
        public int NumberOfLecturers;
        public void details(string lecturerName, string subjectName, string courseName, int numberOfLecturers)
        {
            LecturerName = lecturerName;
            SubjectName = subjectName;
            CourseName = courseName;
            NumberOfLecturers = numberOfLecturers;
        }
        public void DisplayLectureDetails()
        {
            Console.WriteLine("Lecturer Name: " + LecturerName);
            Console.WriteLine("Subject Name: " + SubjectName);
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Number of  lecturers: " + NumberOfLecturers);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lecture[] lectures = new Lecture[5];
            lectures[0] = new Lecture();
            lectures[0].details("KRUTIKA", "Cosmology", "Aerospace Engineering", 22);
            lectures[1] = new Lecture();
            lectures[1].details("SHRUTI", "Physics", "Science", 24);
            lectures[2] = new Lecture();
            lectures[2].details("VIDHI", "Biology", "Medical", 25);
            lectures[3] = new Lecture();
            lectures[3].details("KANISHKA", "Geography", "Social Science", 22);
            lectures[4] = new Lecture();
            lectures[4].details("JANHVI", "Python", " Computer Science", 26);
            for (int i = 0; i < lectures.Length; i++)
            {
                lectures[i].DisplayLectureDetails();
            }
            //foreach (var lecture in lectures)
            //{
            //    lecture.DisplayLectureDetails();
            //}
            Console.ReadLine();
        }
    }
}
