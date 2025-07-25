// public class Person
// {

//     public  void GetRole()
//     {
//         Console.WriteLine("Person class");
//     }

// }

// public class Teacher : Person
// {
//     //Generally it's overriden but you are hiding that method in the inherited class
//     public  void GetRole()
//     {
//         Console.WriteLine("She is a teacher");
//     }

// }

// public class Mother : Person
// {
//     //Generally it's overriden but you are hiding that method in the inherited class
//     public  void GetRole()
//     {
//         Console.WriteLine("She is a Mother");
//     }

// }

// public class MainProgram
// {
//     static void Main()
//     {
//         //Late Binding - RunTime Polymorphism
//         Person p = new Teacher();
//         Person p1 = new Mother();

//         p.GetRole();
//         p1.GetRole();
//     }
// }

// both are having the Car() method but without virtual and override keyword it's not overriding -- they just hide 