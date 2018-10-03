using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]

class Student

{
     public int rollno;
    public string name;
    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
}
public class Serialization
{
    public static void Main(string[] args)
    {
        FileStream stream = new FileStream("e:\\Serialize1.txt", FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();

        Student s = new Student(101, "Janmejay");
        formatter.Serialize(stream, s); //BinaryFormatter.Serialize(stream, reference)

        stream.Close();
        Console.Read();
    }
}