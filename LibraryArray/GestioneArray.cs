using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryArray
{
    public class GestioneArray
    {
       
        public static void LeggiArray(int[] array)
        {
            for (int l = 0; l < array.Length; l++)
            {
                Console.Write($"Inserisci l'elemento in posizione {l}:  ");
                int a = int.Parse(Console.ReadLine());
                array[l] = a;
            }
        }
        public static void StampaArray(int[] array)
        {
            for (int l = 0; l < array.Length; l++)
            {
                Console.Write(array[l] + " ");
            }
        }
        public static int[] CopiaArrayInt(int[] array)
        {
            int[] array2 = new int[array.Length];
            for (int l = 0; l < array.Length; l++)
            {
                array2[l] = array[l];
            }
            return array2;
        }
        public static bool RicercaArrayInt(int[] array, int elemento)
        {
            bool trovato = false;
            for (int l = 0; l < array.Length; l++)
            {
                if (array[l] == elemento)
                    trovato = true;
            }
            return trovato;
        }
        public static bool SonoUgualiInt(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            bool risposta = true;
            for (int l = 0; l < array1.Length; l++)
            {
                if (array1[l] != array2[l])
                    risposta = false;
            }
            return risposta;
        }
        public static void LeggiArrayDouble(double[] array)
        {
            for (int l = 0; l < array.Length; l++)
            {
                Console.WriteLine($"Inserisci l'elemento in posizione {l}:  ");
                array[i] = double.Parse(Console.ReadLine());
            }
        }
        public static void StampaArrayDouble(double[] array)
        {
            for (int l = 0; l < array.Length; l++)
            {
                Console.WriteLine(array[l]);
            }
        }
        public static double[] CopiaArrayDouble(double[] array)
        {
            double[] array2 = new double[array.Length];
            for (int l = 0; l < array.Length; l++)
            {
                array2[l] = array[l];
            }
            return array2;
        }
        public static bool RicercaArrayDouble(double[] array, double elemento)
        {
            bool trovato = false;
            for (int l = 0; l < array.Length; l++)
            {
                if (array[l] == elemento)
                    trovato = true;
            }
            return trovato;
        }
        public static bool SonoUgualiDouble(double[] array1, double[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            bool risposta = true;
            for (int l = 0; l < array1.Length; l++)
            {
                if (array1[l] != array2[l])
                    risposta = false;
            }
            return risposta;
        }

        public static void LeggiArrayString(string[] array)
        {
            for (int l = 0; l < array.Length; l++)
            {
                Console.WriteLine($"Inserisci l'elemento in posizione {l}:  ");
                array[l] = Console.ReadLine();
            }
        }
        public static void StampaArrayString(string[] array)
        {
            for (int l = 0; l < array.Length; l++)
            {
                Console.WriteLine(array[l]);
            }
        }
        public static string[] CopiaArrayString(string[] array)
        {
            string[] array2 = new string[array.Length];
            for (int l = 0; l < array.Length; l++)
            {
                array2[l] = array[l];
            }
            return array2;
        }
        public static bool RicercaArrayString(string[] array, string elemento)
        {
            bool trovato = false;
            for (int l = 0; l < array.Length; l++)
            {
                if (array[l] == elemento)
                    trovato = true;
            }
            return trovato;
        }
        public static bool SonoUgualiString(string[] array1, string[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            bool risposta = true;
            for (int l = 0; l < array1.Length; l++)
            {
                if (array1[l] != array2[l])
                    risposta = false;
            }
            return risposta;
        }
        public static int CercaMax(int[] array)
        {
            int max = int.MinValue;
            for (int l = 0; l < array.Length; l++)
            {
                if (array[l] > max)
                    max = array[l];
            }
            return max;
        }
        public static int CercaMin(int[] array)
        {
            int min = int.MaxValue;
            for (int l = 0; l < array.Length; l++)
            {
                if (array[l] < min)
                    min = array[l];
            }
            return min;
        }
        public static bool Crescente(int[] array)
        {
            bool risposta = true;
            for (int l = 1; l < array.Length; l++)
            {
                if (array[l] <= array[l - 1])
                    risposta = false;
            }
            return risposta;
        }
        public static bool Decrescente(int[] array)
        {
            bool risposta = true;
            for (int l = 1; l < array.Length; l++)
            {
                if (array[l] >= array[l - 1])
                    risposta = false;
            }
            return risposta;
        }
    }
}
