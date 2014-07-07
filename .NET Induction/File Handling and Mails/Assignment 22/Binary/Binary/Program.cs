using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("Binary.txt", FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(11);
            writer.Write("Ipsit");
            writer.Write('G');
            writer.Close();
            stream = new FileStream("Binary.txt", FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadString());
            Console.WriteLine(reader.ReadChar());
            Console.ReadLine();
        }
    }
}
