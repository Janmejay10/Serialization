using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace SerializationAndXml
{
    [Serializable]
    class Deserial_demo
    {
        public static void Main()
        {
            FileStream fs = new FileStream("f:\\serial_demo.txt", FileMode.Open);
            BinaryFormatter bfm = new BinaryFormatter();
            Serialize1 sr = (Serialize1)bfm.Deserialize(fs);
            Console.WriteLine("std_id = " + sr.std_id);
            Console.WriteLine("std_name= " + sr.std_name);
            Console.ReadLine();


        }
    }
}
