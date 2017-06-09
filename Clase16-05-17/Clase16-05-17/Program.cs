using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3_12_5_2017
{
    class Program
    {
        static string alphabet = "aábcdeéfghiéjklmnñoópqrstuúüvwxyzAÁBCDEÉFGHIÍJKLMNÑOÓPQRSTUÚÜVWXYZ";
        static int[] keys = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

        static void Main(string[] args)
        {

            string message = "Mb fcyb dhrqb zbFgéñégr yñ dhRégñ, gi rérf ehüra yñ gÜrar ehr ñgéñjrFñé. Üvxaéalaosevélv vjvk vd vdvyaüg.";

            string[] sentences = message.Split('.');

            int numSentences = 0;
            foreach (string sentence in sentences)
            {
                if (sentence != "") {
                    numSentences++;
                }
            }

            int k = keys[6];

            foreach (string sentence in sentences)
            {
                Console.WriteLine(Decrypt(sentence.TrimStart(), k));
                k = keys[6+numSentences];
            }


            Console.ReadKey();
        }

        /**
         * Desencripta un mensaje aplicando el desplazamiento que
         * recibe como parámetro.
         * */
        static string Decrypt(string msg, int shift) {
            string code = "";
            if(shift > 0 && shift < alphabet.Length){
                for (int i = 0; i < msg.Length; i++ ) { 
                    int cpos = CharPosition(msg[i]);
                    if (cpos != -1)
                    {
                        int pos = cpos - shift;
                        while (pos < 0)
                        {
                            pos = pos + alphabet.Length;
                        }
                        code += alphabet[pos];
                    }
                    else {
                        code += msg[i];
                    }
                }
            }
            return code;
        }

        /**
         * Devuelve la posición en el alfabeto del caracter que se le pasa
         * como parámentro.
         * */
        static int CharPosition(char c)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (c == alphabet[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /**
         * Encripta un mensaje aplicando el desplazamiento que recibe como parámetro.
         * */
        static string Encrypt(string msg, int shift)
        {
            string code = "";
            if (shift > 0 && shift < alphabet.Length)
            {
                for (int i = 0; i < msg.Length; i++)
                {
                    int cpos = CharPosition(msg[i]);
                    if (cpos != -1)
                    {
                        int pos = cpos + shift;
                        while (pos >= alphabet.Length)
                        {
                            pos = pos - alphabet.Length;
                        }
                        code += alphabet[pos];
                    }
                    else
                    {
                        code += msg[i];
                    }
                }
            }
            return code;
        }
    }
}
