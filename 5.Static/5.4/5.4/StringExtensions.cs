using System;

namespace _5._4
{
    static class StringExtensions
    {
        public static string MySubstring(this string str, int index, int count)
        {
            if(str != null && index > -1 && count > 0)
            {
                string newString = "";

                try
                {
                    for (int i = 0; i < count; i++)
                    {
                        newString += str[index + i];
                    }
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine("Ура, исключение! - " + e.Message + " :з");
                }

                return newString;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public static int MyIndexOf(this string str, string value)
        {
            int index = -1;
            if(str != null && value != null && value.Length > 0 && str.Length >= value.Length)
            {
                for(int i = 0; i < str.Length; i++)
                {
                    string temp = "";

                    for (int j = 0; j < value.Length; j++)
                    {
                        try
                        {
                            temp += str[i + j];
                        }
                        catch(IndexOutOfRangeException e) { }
                    }

                    if (value == temp)
                    {
                        index = i;
                        break;
                    }
                }
            }

            return index;
        }
        public static string MyReplace(this string str, string oldValue, string newValue)
        {
            if(oldValue != null && newValue != null && oldValue != "" && newValue != "")
            {
                for(int i = 0; i < str.Length; i++)
                {
                    string temp = "";

                    for (int j = 0; j < oldValue.Length; j++)
                    {
                        try
                        {
                            temp += str[i + j];
                        }
                        catch
                        {
                            break;
                        }
                    }

                    if(temp == oldValue)
                    {
                        str = str.Remove(i, oldValue.Length);
                        str = str.Insert(i, newValue);
                        i = -1;
                    }
                }

                return str;
            }
            else
            {
                return str;
            }
        }
    }
}
