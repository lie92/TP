using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyMiniMips
{
    class CPU
    {
        
        public Byte[] ram;
        public int[] tab;
        public int Program_counter;
 

        public CPU(string filename)
        {
            ram = new Byte[64 * 1024];
            tab = new int[32];
            Program_counter = 0;
            LoadFile(filename);

        }
        public void LoadFile(string fileName)
        {

            try
            {
                FileStream fs = File.Open(fileName, FileMode.Open);

                BinaryReader bin = new BinaryReader(File.Open(fileName, FileMode.Open));
                //for (int i = 0; i < 64 * 1024; i++)
                //{
                //    ram[i] = bin.ReadByte();
                //}
                byte[] f = bin.ReadBytes((int)fs.Length);
                for(int i = 0; i<fs.Length; i++)
                {
                    ram[i] = f[i];
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}