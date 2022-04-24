using System;

namespace _24042022task
{
    static class Program
    {
        static void Main(string[] args)
        {
            string text = "exTensiON clASSi StaTiC OlMaLiDIR";
            text = text.Capitalize();
            Console.WriteLine(text);
        }
        public static string Capitalize(this string text)
        {
            text = text.ToLower();
            string[] promises = text.Split(' ');
            string newtext = " ";
            foreach (var promise in promises)
            {
                string newPromise = char.ToUpper(promise[0]) + promise.Substring(1) + "";
                newtext += newPromise;
            }
            return text = newtext;

        }
    }
}
