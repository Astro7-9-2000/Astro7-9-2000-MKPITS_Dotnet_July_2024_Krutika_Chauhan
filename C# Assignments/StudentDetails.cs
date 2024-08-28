/* Write a program to display in this format using class RollNo Sub1 Sub2 Sub3 Total Percentage
 1 30 25 45 100
 3 20 15 35 70
 4 35 30 40 105*/

 using System;
 // class defination
 public class StudentDetails
 {
     public int RollNo;
     public string Sub1;
     public string Sub2;
     public string Sub3;
     public int Total;
     public float Percentage;

     // Setvalues sets the values of the student details
     public void SetValues (int rollno , string sub1 , string sub2 , string sub3 , int total , float percentage)
     {

     // RollNo is the property of the StudentDetails class and rollno is the parameter of the setValues Method which is passed when the method is called.

     RollNo = rollno;   //This line assigns the value of rollno to the  RollNo property of the StudentDetails object.

     Sub1 = sub1; // Assigns the value of sub1 parameter to the Sub1 property of the StudentDetails object.

     Sub2 = sub2; // Assigns the value of sub2 parameter to the Sub2 property of the StudentDetails object.

     Sub3 = sub3;  // Assigns the value of sub3 parameter to the Sub3 property of the StudentDetails object.

     Total = total; // Assigns the value of total parameter to the Total property of the StudentDetails object.

     Percentage = percentage; // Assigns the value of percentage parameter to the Percentage property of the StudentDetails object.
 }

     // Syntax - Access specifier return type methodName
     public void ShowValues()
     {
         Console.WriteLine(RollNo + " " + Sub1 + " " + Sub2 + " " + Sub3 + " " + Total + " " + Percentage.ToString("F2"));
     }
public static void Main(string[] args)
  {

     // Objects of StudentDetails Class

     StudentDetails student1 = new StudentDetails();
     student1.SetValues(1 , "30" , "25" , "45" , 100 , 100.0f);
     student1.ShowValues();

     StudentDetails student2 = new StudentDetails();
     student2.SetValues(2 , "25" , "20" , "25" ,70 , 70.0f);
     student2.ShowValues();

     StudentDetails student3 = new StudentDetails();
     student3.SetValues(3 ,  "20" ,  "15" ,  "35" , 70 , 70.0f);
     student3.ShowValues();

     StudentDetails student4 = new StudentDetails();
     student4.SetValues(4 , "35" , "30" ,  "40" , 105 ,  105.0f);
     student4.ShowValues();
  }
  }
