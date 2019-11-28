using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicToRomanNumerals
{
    public class TestClass
    {
        public int Convert(string param)
        {
            int translatedValue = 0;
            int paramLength = param.Length;

            for(int i =0; i < paramLength; i++)
            {
                if(i > 0)
                {
                    if(GetArabicValue(param[i]) > GetArabicValue(param[i - 1]))
                    {
                        translatedValue = translatedValue - GetArabicValue(param[i - 1]);
                        translatedValue += GetArabicValue(param[i]) - GetArabicValue(param[i - 1]);
                    }
                    else
                    {
                        translatedValue += GetArabicValue(param[i]);
                    }
                }
                else
                {
                    translatedValue += GetArabicValue(param[i]);
                }
                
            }

            return translatedValue;
        }

        private int GetArabicValue(char param)
        {
            int value = (int)Enum.Parse(typeof(RomanNumerals), param.ToString());
            return value;
        }
    }
}
