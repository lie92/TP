using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMiniMips
{
    public class Instruction
    {
        public int Op { get; private set; }
        public int Rs { get; private set; }
        public int Rt { get; private set; }
        public int Rd { get; private set; }
        public int Funct { get; private set; }
        public int Imm { get; private set; }
        public int Addr { get; private set; }

        public Instruction (int ins)
        {
            Op = ins >> 26;
            Rs = ins >> 21 - Op << 6;
            Rt = ins >> 16 - Op << 11 - Rs << 5;
            Funct = ins & 0x0000002F;
            Rd = (ins << 16 ) >> 27;
            Imm = (ins << 16 ) >> 16;
            Addr = (ins << 6 ) >> 6;
            print();
        }
        public void print ()
        {
            Console.WriteLine("op "+Op);
            Console.WriteLine("rs "+Rs);
            Console.WriteLine("rt "+Rt);
            Console.WriteLine("rd "+Rd);
            Console.WriteLine("funct "+Funct);
            Console.WriteLine("imm "+Imm);
            Console.WriteLine("addr "+Addr);
        }
    }
}
