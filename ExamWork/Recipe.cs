using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWork
{
    public class Recipe
    {
        public Material[] Components { get; set; }

        public string Material { get; set; }

        public Recipe()
        {
            Components = new Material[9];
        }
        
        public string Sum()
        {
            string myStr = "";
            foreach (var item in Components)
            {
                myStr += item.Name;
            }
            return myStr;
        }

        public bool Pick(string recipeLine)
        {
            if(recipeLine == "MMMXsXXsX")
            {
                return true;
            }
            return false;
        }

        public bool Shovel(string recipeLine)
        {
            if (recipeLine == "XMXXsXXsX")
            {
                return true;
            }
            return false;
        }

        public bool Axe(string recipeLine)
        {
            if (recipeLine == "MMXMsXXsX")
            {
                return true;
            }
            return false;
        }

        public bool Sword(string recipeLine)
        {
            if (recipeLine == "XMXXMXXsX")
            {
                return true;
            }
            return false;
        }

        public bool Hoe(string recipeLine)
        {
            if(recipeLine == "MMXXsXXsX")
            {
                return true;
            }
            return false;
        }


        public char[] Format(string recipeLine)
        {
            char[] array = recipeLine.ToCharArray();
            char material = array[1];
            switch (material)
            {
                case 'D':
                    Material = "Diamond";
                    break;
                case 'W':
                    Material = "Wooden";
                    break;
                case 'I':
                    Material = "Iron";
                    break;
                case 'S':
                    Material = "Stone";
                    break;
                default:
                    break;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] != 'X' && array[i] != 's' && array[i] == material)
                {
                    array[i] = 'M';
                }
            }
            return array;
        }
    }
}
