using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWork
{
    public class Material
    {
        public string Name { get; set; }

        public static string operator +(Material first, Material second)
        {
            return String.Concat(first.Name, second.Name);
        }
    }
}
