namespace ClassRoomNet60;

public class Student
{
    public string Name { get; private set; }
    public int BirthMonth { get; private set; }
    public int Birthday { get; private set; }

    public Student(string name, int birthMonth, int birthday)
    {
        Name = name;
        BirthMonth = birthMonth;
        Birthday = birthday;
    }
}
