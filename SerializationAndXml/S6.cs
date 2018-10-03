using System;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializationAndXml

{
    [Serializable]
    class Serialize1
    {
        public int std_id;
        public string std_name;
        public Serialize1(int std_id, string std_name)
        {
            this.std_id = std_id;
            this.std_name = std_name;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("f://serial_demo.txt", FileMode.OpenOrCreate);
            BinaryFormatter bfm = new BinaryFormatter();
            Serialize1 sr = new Serialize1(500, "Jason Stathon");
            bfm.Serialize(fs, sr);
            fs.Close();
            Console.WriteLine("Serialization is done!");
            Console.ReadLine();
        }
    }
}
