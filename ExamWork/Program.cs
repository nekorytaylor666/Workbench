using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWork
{
    class Program
    {
        static Recipe recipe = new Recipe();

        static Point point = new Point();


        static void Main(string[] args)
        {
            Material material1 = new Material {Name = "X"};
            Material material2 = new Material { Name = "X"};
            Material material3 = new Material { Name = "X"};
            Material material4 = new Material { Name = "X"};
            Material material5 = new Material { Name = "X"};
            Material material6 = new Material { Name = "X"};
            Material material7 = new Material { Name = "X"};
            Material material8 = new Material { Name = "X"};
            Material material9 = new Material { Name = "X"};
            recipe.Components[0] = material1;
            recipe.Components[1] = material2;
            recipe.Components[2] = material3;
            recipe.Components[3] = material4;
            recipe.Components[4] = material5;
            recipe.Components[5] = material6;
            recipe.Components[6] = material7;
            recipe.Components[7] = material8;
            recipe.Components[8] = material9;

            int choose = 11;

            while(choose != 0)
                choose = menu();
            


            Console.Read();
        }

        static void DrawBoard() 
        {
            Console.WriteLine($"1.{recipe.Components[0].Name}  |2.{recipe.Components[1].Name}  |3.{recipe.Components[2].Name}   ");
            Console.WriteLine("-------------------");
            Console.WriteLine($"4.{recipe.Components[3].Name}  |5.{recipe.Components[4].Name}  |6.{recipe.Components[5].Name}   ");
            Console.WriteLine("-------------------");
            Console.WriteLine($"7.{recipe.Components[6].Name}  |8.{recipe.Components[7].Name}  |9.{recipe.Components[8].Name}   ");
        }

        static int menu()
        {
            DrawBoard();

            Console.WriteLine("Введите по какой позиции хотите поставить элемент. \nДля проверки нажмите на 0.");

            int choose = Convert.ToInt16(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    point.x = 3;
                    point.y = 0;
                    break;
                case 2:
                    point.x = 9;
                    point.y = 0;
                    break;
                case 3:
                    point.x = 15;
                    point.y = 0;
                    break;
                case 4:
                    point.x = 3;
                    point.y = 1;
                    break;
                case 5:
                    point.x = 9;
                    point.y = 1;
                    break;
                case 6:
                    point.x = 15;
                    point.y = 1;
                    break;
                case 7:
                    point.x = 3;
                    point.y = 2;
                    break;
                case 8:
                    point.x = 9;
                    point.y = 2;
                    break;
                case 9:
                    point.x = 15;
                    point.y = 2;
                    break;
                case 0:
                    CheckRecipe();
                    return 0;
                default:
                    break;
            }

            Console.SetCursorPosition(point.x, point.y);

            ShowMaterials();

            int materialChoose = Convert.ToInt16(Console.ReadLine());

            switch (materialChoose)
            {
                case 1:
                    recipe.Components[choose-1].Name = "D";
                    break;
                case 2:
                    recipe.Components[choose-1].Name = "S";
                    break;
                case 3:
                    recipe.Components[choose-1].Name = "I";
                    break;
                case 4:
                    recipe.Components[choose-1].Name = "W";
                    break;
                case 5:
                    recipe.Components[choose-1].Name = "s";
                    break;
                default:
                    break;
            }            

            Console.SetCursorPosition(point.x, point.y);

            Console.Write(recipe.Components[choose].Name);

            Console.Clear();
            return 1;
        }

        static void ShowMaterials()
        {
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Выберите материал, который хотите поставить");
            Console.WriteLine("1. Алмаз.\n2. Камень\n3. Железо\n4. Дерево\n5. Палка");
        }

        static void CheckRecipe()
        {

            char[] str = recipe.Format(recipe.Sum());

            String str2 = new String(str);

            if (recipe.Pick(str2))
            {
                Console.WriteLine($"You made {recipe.Material} Pick");
            }
            else if (recipe.Axe(str2))
            {
                Console.WriteLine($"You made {recipe.Material} Axe");
            }
            else if (recipe.Shovel(str2))
            {
                Console.WriteLine($"You made {recipe.Material} Shovel");
            }
            else if (recipe.Sword(str2))
            {
                Console.WriteLine($"You made {recipe.Material} Sword");
            }
            else if (recipe.Hoe(str2))
            {
                Console.WriteLine($"You made {recipe.Material} Hoe");
            }
            else
            {
                Console.WriteLine("Ничего не вышло..");
            }
        }

    }
}
