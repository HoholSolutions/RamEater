using System;
using System.Collections.Generic;

namespace ByeRam
{
    class Program
    {
        static void Main()
        {
            List<List<Object>> bomb_list_object = new List<List<Object>>();
            List<byte[]> bomb_list_byte = new List<byte[]>();
            List<char[]> bomb_list_char = new List<char[]>();
            while (true)
            {
                bomb_list_object.Add(new List<Object>() { new Object() });
                bomb_list_byte.Add(new byte[10000]);
                bomb_list_char.Add(new char[10000]);
            }
        }
    }
}
