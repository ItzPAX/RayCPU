using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCPU
{
    enum OPCODE
    {
        mov,
        add,
        sub,
        mul,
        div,
        prnt,
    }

    internal class Memory
    {
        uint[] mem = new uint[1024];
    }

    internal class CPU
    {
        uint[] r = new uint[3];

        OPCODE FindOpcode(string opcode)
        {
            return (OPCODE)Enum.Parse(typeof(OPCODE), opcode);
        }

        public void Run(string[] lines)
        {
            foreach (var line in lines)
            {
                var lowerline = line.ToLower();

                string[] instructions = lowerline.Split(' ');

                string opcode = instructions[0];
                string[] operands = lowerline.Replace(opcode, "").Replace(" ", "").Split(',');

                switch (FindOpcode(opcode))
                {
                    case OPCODE.mov:
                        if (operands[0].ToLower()[0] == 'r')
                        {
                            r[int.Parse(operands[0].Replace("r", "")) - 1] = uint.Parse(operands[1]);
                        }
                        break;

                    case OPCODE.sub:
                        if (operands[0].ToLower()[0] == 'r')
                        {
                            r[int.Parse(operands[0].Replace("r", "")) - 1] -= uint.Parse(operands[1]);
                        }
                        break;

                    case OPCODE.add:
                        if (operands[0].ToLower()[0] == 'r')
                        {
                            r[int.Parse(operands[0].Replace("r", "")) - 1] += uint.Parse(operands[1]);
                        }
                        break;

                    case OPCODE.prnt:
                        if (operands[0].ToLower()[0] == 'r')
                        {
                            Console.WriteLine(r[int.Parse(operands[0].Replace("r", "")) - 1]);
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
