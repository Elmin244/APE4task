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
            StringBuilder sb = new StringBuilder();
            string[] promises = text.Split(' ');
            foreach (var promise in promises)
            {
                sb.Append(char.ToUpper(promise[0]) + promise.Substring(1) + " ");
            }
            return text = sb.ToString();

        }
    }
}
