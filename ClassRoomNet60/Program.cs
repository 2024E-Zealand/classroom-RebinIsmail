using ClassRoomNet60;

class Program
{
    static void Main()
    {
        ClassRoom classRoom = new ClassRoom()
        {
            ClassName = "3B",
            SemesterStart = new DateTime(2019, 8, 26)
        };
        
        classRoom.StudentList.Add(new Student("Rebin", 6, 15)); 
        classRoom.StudentList.Add(new Student("Mads", 7, 10));

        
        Console.WriteLine($"Class Name: {classRoom.ClassName}");
        Console.WriteLine($"Semester Start: {classRoom.SemesterStart}");
        Console.WriteLine("Student List:");
        foreach (Student Student in classRoom.StudentList)
        {
            Console.WriteLine($"- Name: {Student.Name}, Birthdate: {Student.Birthday}/{Student.BirthMonth}");
        }
    }
    
 

    
}