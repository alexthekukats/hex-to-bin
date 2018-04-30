using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hex_to_bin
{
    class Program
    {
        static void Main(string[] args)
        {


            var list = new List<byte> { 0x1A, 0x0F, 0x83 }.ToArray();

            using (var s = File.Open("test.bin", FileMode.Create))
            using (var tw = new BinaryWriter(s))
                tw.Write(list);

        }
    }
}
