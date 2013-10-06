using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    // Återanvändning är bra för miljön! ;)
    public static class Rovarsprak
    {
        public static string rova(this string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (arKonsonant(text[i]))
                {
                    text = rovarisera(text, i);
                    i += 2;
                }
            }
            return text;
        }

        public static string orova(this string text)
        {
            for (int i = 0; i < text.Length - 2; i++)
            {
                text = orovarisera(text, i);
            }
            return text;
        }

        private static bool arVokal(char c)
        {
            char c2 = char.ToLower(c);
            return c2 == 'a' || c2 == 'e' || c2 == 'i'
                || c2 == 'o' || c2 == 'u' || c2 == 'y'
                || c2 == 'å' || c2 == 'ä' || c2 == 'ö';
        }

        private static bool arKonsonant(char c)
        {
            return (char.IsLetter(c) && !arVokal(c));
        }

        private static string rovarisera(string text, int plats)
        {
            string tillagg = "o" + char.ToLower(text[plats]);
            string resultat = text.Insert(plats + 1, tillagg);
            return resultat;
        }

        private static string orovarisera(string text, int plats)
        {
            string text2 = text.ToLower();
            char tecknet = text2[plats];
            if (arKonsonant(tecknet) && text2[plats + 1] == 'o' && text2[plats + 2] == tecknet)
            {
                text = text.Remove(plats + 1, 2);
            }
            return text;
        }
    }
}
