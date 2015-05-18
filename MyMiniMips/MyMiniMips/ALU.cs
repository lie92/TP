using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMiniMips
{
    public class ALU
    {
        public CPU cpu;
        public ALU(CPU cpu)
        {
            this.cpu = cpu;
        }

        public void Exec(Instruction i)
        {
            if (i.Funct == 8)
            {
                int a = cpu.tab[2];

                switch (a)
                {
                    case 1:
                        Console.WriteLine(cpu.tab[8]);
                        break;
                    case 4:
                        int i = cpu.tab[2];
                        while(cpu.ram[cpu.tab[2]] != null)
                        {
                            
                        }
                   

                }
            }
        }

    }

}
