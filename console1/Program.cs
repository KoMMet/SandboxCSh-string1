using System;
using System.Text;

namespace console1
{
    class Program
    {
        public static void Main()
        {
            string intstr = $"abcdefghijklmnopqrstuvwxyz";
            string line = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            if (line == null)
            {
                return;
            }
            for (int i = 0; i < line.Length; i++)
            {
                int pls = intstr.IndexOf(line[i]);
                if (pls != -1)
                {
                    builder.Append(pls);
                }
                else
                {
                    builder.Append(line[i]);
                }
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
