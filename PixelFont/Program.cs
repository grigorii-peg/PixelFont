using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelFont
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 0 до 9: ");
            var n = Console.ReadLine();
            int i = 0;          
            char [] chars = n.ToCharArray();
            var count = chars.Length;
            var xx = count * 4;
            int x = (Console.WindowWidth / 2) - (xx / 2);
            int y = (Console.WindowHeight / 3);
            while (count > i)
            {
                Console.SetCursorPosition(x, y);
                if (chars[i] == '0')
                {
                    string[] mas0 =
                    {
                        " ██ ",
                        "█  █",
                        "█  █",
                        "█  █",
                        " ██ "
                    };
                    for(int j = 0; j < mas0.Length; j++)
                    {
                        Console.WriteLine(mas0[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 6;
                    y = (Console.WindowHeight) / 3;
                }
                else if (chars[i] == '1')
                {
                    string[] mas1 =
                    {
                        " █  ",
                        "██  ",
                        " █  ",
                        " █  ",
                        "███ "
                    };
                    for (int j = 0; j < mas1.Length; j++)
                    {
                        Console.WriteLine(mas1[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 4;
                    y = (Console.WindowHeight) / 3;
                }
                else if (chars[i] == '2')
                {
                    string[] mas2 =
                    {
                        "███ ",
                        "   █",
                        " ██ ",
                        "█   ",
                        "████"
                    };
                    for (int j = 0; j < mas2.Length; j++)
                    {
                        Console.WriteLine(mas2[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 5;
                    y = (Console.WindowHeight) / 3;
                }
                else if (chars[i] == '3')
                {
                    string[] mas3 =
                    {
                        "███ ",
                        "   █",
                        " ██ ",
                        "   █",
                        "███ "
                    };
                    for (int j = 0; j < mas3.Length; j++)
                    {
                        Console.WriteLine(mas3[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 5;
                    y = (Console.WindowHeight) / 3;
                }
                else if (chars[i] == '4')
                {
                    string[] mas4 =
                       {
                        "█  █",
                        "█  █",
                        "████",
                        "   █",
                        "   █"
                    };
                    for (int j = 0; j < mas4.Length; j++)
                    {
                        Console.WriteLine(mas4[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 5;
                    y = (Console.WindowHeight) / 3;
                }
                else if (chars[i] == '5')
                {
                    string[] mas5 =
                       {
                        "████",
                        "█   ",
                        "███ ",
                        "   █",
                        "███ "
                    };
                    for (int j = 0; j < mas5.Length; j++)
                    {
                        Console.WriteLine(mas5[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 5;
                    y = (Console.WindowHeight) / 3;                
                }
                else if (chars[i] == '6')
                {
                    string[] mas6 =
                       {
                        " ██ ",
                        "█   ",
                        "███ ",
                        "█  █",
                        " ██ "
                    };
                    for (int j = 0; j < mas6.Length; j++)
                    {
                        Console.WriteLine(mas6[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 5;
                    y = (Console.WindowHeight) / 3;                   
                }
                else if (chars[i] == '7')
                {
                    string[] mas7 =
                       {
                        "████",
                        "   █",
                        "  █ ",
                        " █  ",
                        " █  "
                    };
                    for (int j = 0; j < mas7.Length; j++)
                    {
                        Console.WriteLine(mas7[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 5;
                    y = (Console.WindowHeight) / 3;
                }
                else if (chars[i] == '8')
                {
                    string[] mas8 =
                       {
                        " ██ ",
                        "█  █",
                        " ██ ",
                        "█  █",
                        " ██ "
                    };
                    for (int j = 0; j < mas8.Length; j++)
                    {
                        Console.WriteLine(mas8[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 5;
                    y = (Console.WindowHeight) / 3;
                }
                else if (chars[i] == '9')
                {
                    string[] mas9 =
                       {
                        " ██ ",
                        "█  █",
                        " ███",
                        "   █",
                        " ██ "
                    };
                    for (int j = 0; j < mas9.Length; j++)
                    {
                        Console.WriteLine(mas9[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 5;
                    y = (Console.WindowHeight) / 3;
                }
                else if (chars[i] == '.')
                {
                    string[] mas_dot =
                       {
                        "    ",
                        "    ",
                        "    ",
                        "    ",
                        "■   "
                    };
                    for (int j = 0; j < mas_dot.Length; j++)
                    {
                        Console.WriteLine(mas_dot[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 2;
                    y = (Console.WindowHeight) / 3;
                }
                else if (chars[i] == ',')
                {
                    string[] mas_comma =
                       {
                        "    ",
                        "    ",
                        "    ",
                        "    ",
                        "█   ",
                        " █  ",                       
                    };
                    for (int j = 0; j < mas_comma.Length; j++)
                    {
                        Console.WriteLine(mas_comma[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 3;
                    y = (Console.WindowHeight) / 3;
                }
                else if (chars[i] == ' ')
                {
                    string[] mas_space =
                       {
                        "    ",
                        "    ",
                        "    ",
                        "    ",
                        "    ",
                    };
                    for (int j = 0; j < mas_space.Length; j++)
                    {
                        Console.WriteLine(mas_space[j]);
                        Console.SetCursorPosition(x, ++y);
                    }
                    i++;
                    x += 3;
                    y = (Console.WindowHeight) / 3;
                }

            }
            Console.ReadKey();
        }
    }
}
