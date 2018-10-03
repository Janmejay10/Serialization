using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
[Serializable]
class Student1
{
    public int rollno;
    public string name;
    public Student1(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
}
public class Deserialization
{
    public static void Main(string[] args)
    {
        FileStream stream = new FileStream("e:\\Serialize1.txt", FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();
       // Student s2 = new Student(102,"ads");
        

        Student s = (Student)formatter.Deserialize(stream);
        Console.WriteLine("Rollno: " + s.rollno);
        Console.WriteLine("Name: " + s.name);

        stream.Close();
        Console.Read();
    }
}