using System;

class Program
 {
//     static void Main()
//     {
//         string[] students = new string[10]; // We can store 10 names
//         int count = 0; // Number of students
//         int choice;

//         do
//         {
//             Console.WriteLine("\n1. Add Student");
//             Console.WriteLine("2. View Students");
//             Console.WriteLine("3. Delete Last Student");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your choice: ");
//             choice = Convert.ToInt32(Console.ReadLine());

//             if (choice == 1)
//             {
//                 if (count < 10)
//                 {
//                     Console.Write("Enter student name: ");
//                     students[count] = Console.ReadLine();
//                     count++;
//                     Console.WriteLine("Student added.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("List full.");
//                 }
//             }
//             else if (choice == 2)
//             {
//                 Console.WriteLine("Student List:");
//                 for (int i = 0; i < count; i++)
//                 {
//                     Console.WriteLine((i + 1) + ". " + students[i]);
//                 }
//             }
//             else if (choice == 3)
//             {
//                 if (count > 0)
//                 {
//                     count--;
//                     Console.WriteLine("Last student deleted.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("List is empty.");
//                 }
//             }
//             else if (choice == 4)
//             {
//                 Console.WriteLine("Exiting...");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid choice.");
//             }

//         } while (choice != 4);
//     }
}