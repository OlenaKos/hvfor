using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hvfor
{
     class Homework
    {

        public string printNumbers20()
        {
            string s = "";
            
            for (int i = 0; i < 6; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    s += "2 ";
                }
                s += "\n";
                for (int j = 5; j > i; j--)
                {
                    s += $"{8 - i - j} ";
                }
                s += "\n";
            }
            return s;
        }
        public static string printNumbers19()
        {
            string s = "";
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j + 1 == i)
                    {
                        s += "3 "; 
                    }
                    else
                    {
                        s += "2 ";
                    }
                }
                s += "\n";
                for (int j = 0; j < i; j++)
                {
                    if (j + 1 == i)
                    {
                        s += "0 "; 
                    }
                    else
                    {
                        s += $"{11 - i + j} ";
                    }
                }
                s += "\n";
            }
            return s;
        }
        public static string printNumbers18()
        {
            string s = "";
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    s += $"{10 - i} ";
                }
                s += "\n";
                for (int j = 0; j < i; j++)
                {
                    s += $"{5 - i} ";
                }
                s += "\n";
            }
            return s;
        }
        public static string printNumbers17()
        {
            string s = "";
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    s+= i + " "; 
                }
                s += "\n";
                for (int j = 0; j < i; j++)
                {
                    s += $"{i + 5} ";
                }
                s += "\n";
            }
            return s;

        }
        public static string printNumbers16()
        {
            string s = "";
            for (int i = 8; i > 4; i--)
            {
                for (int j = 0; j < 9 - i; j++)
                {
                    s += i + " ";
                }
                s += "\n";
                for (int j = 0; j < 9 - i; j++)
                {
                    s += $"{i - 1} ";
                }
                s += "\n";
            }
            return s;
        }
        public static string printNumbers15()
        {
            string s = "";
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    s += i + " ";
                }
                s += "\n";
                for (int j = 0; j < i; j++)
                {
                    s += "0 ";
                }
                s += "\n";
            }
            return s;
        }
        public static string printNumbers14()
        {
            string s = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    s+=$"{4 - j} ";
                }
                s += "\n";
            }
            return s;
        }
        public static string printNumbers13()
        {
            string s = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    s += j + " ";
                }
                s += "\n";
            }
            return s;
        }

        public static string printNumbers12()
        {
            string s = "";
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    s += $"{i - j} "; 
                }
                s += "\n";
            }
            return s;
        }

        public static string printNumbers11()
        {
            string s = "";
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    s += j + " ";
                }
                s += "\n";
            }
            return s;
        }

        public static string printNumbers10()
        {
            string s = "";
            for (int i = 8; i > 3; i--)
            {
                for (int j = 1; j <= i - 3; j++)
                {
                    s += i + " ";
                }
                s += "\n";
            }
            return s;
        }
        public static string printNumbers9()
        {
            string s = "";
            for (int i = 7; i > 2; i--)
            {
                for (int j = 7; j >= i; j--)
                {
                    s += i + " ";
                }
                s += "\n";
            }
            return s;
        }

        public static string printNumbers8()
        {
            string s = "";
            for (int i = 6; i < 11; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    s += i + " ";
                }
                s += "\n";
            }
            return s;
        }

        public static string printNumbers7()
        {
            string s = "";
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    s += i + " ";
                }
                s += "\n";
            }
            return s;
        }

        public static string printNumbers6()
        {
            string s = "";
            for (int i = 1; i < 6; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    s += "1 ";
                }
                s += "\n";
            }
            return s;
        }

        public static string printNumbers5()
        {
            string s = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    s += "5 ";
                }
                s += "\n";
            }
            return s;
        }

        public static string printNumbers4()
        {
            string s = "";
            for (int i = 41; i <= 71; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    s += $"{i + j} "; 
                }
                s += "\n";
            }
            return s;
        }
        public static string printNumbers3()
        {
            string s = "";
            for (int i = 1; i <= 5; i++)
            {
                for (int j = -10; j <= 12; j++)
                {
                    s += j + " "; 
                }
                s += "\n";
            }
            return s;
        }

        public static string printNumbers2()
        {
            string s = "";
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    s+= j + " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}
