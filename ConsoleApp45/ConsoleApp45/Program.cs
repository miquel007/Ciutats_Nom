using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp45
{
    class Program
    {
        private static string ciutat1;
        private static string ciutat2;
        private static string ciutat3;
        private static string ciutat4;
        private static string ciutat5;
        private static string ciutat6;

        static void Main(string[] args)
        {
            List<string> ciutats = new List<string>();
            List<string> ArrayCiutatsModificades = new List<string>();
            List<char[]> listas = new List<char[]>();
            Dictionary<string, List<double>> avaluacio = new Dictionary<string, List<double>>();

            //Milestone1

            //ciutats = omplir();

            //ciutats = ordenar(ciutats);

            //ArrayCiutatsModificades = modificar(ciutats);

            //ArrayCiutatsModificades = ordenar(ArrayCiutatsModificades);

            //listas = desmontar(ciutats);

            //mostrar(ciutats);
            //mostrar(ArrayCiutatsModificades);
            //mostrarinvertit(listas);

            //Milestone2

            //avaluacio = omplir2();

            //mostraravaluacio(avaluacio);

            //Milestone3

            Fibonacci();
        }

        public static void Fibonacci()
        {
            int actual,anterior,resultat,N;

            Console.WriteLine("Indica valor N");
            string Kfake = Console.ReadLine();
            N = Convert.ToInt32(Kfake);

            actual = 0; anterior = 0;resultat = 0;

            Console.WriteLine("\n{0}", resultat);

            resultat++;

            for (int i = 0; i < N-1; i++)
            {
                Console.WriteLine("{0}", resultat);
                anterior = actual;
                actual = resultat;
                resultat = actual + anterior;
            }
        }

        public static void mostraravaluacio(Dictionary<string, List<double>> aval)
        {
            double suma = 0;

            foreach (var conjunto in aval)
            {
                Console.WriteLine("En {0} a tret : ",conjunto.Key);
                List<double> elem = conjunto.Value;
                foreach ( double e in elem)
                {
                    suma = suma + e;
                    Console.Write("{0} ",e);
                }

                suma = suma / 3;

                if (suma < 5)
                    Console.WriteLine("\n En {0} ha suspes ", conjunto.Key);
                else
                    Console.WriteLine("\n En {0} ha aprovat ", conjunto.Key);

                suma = 0;
            }
        }

        public static Dictionary<string, List<double>> omplir2()
        {
            Dictionary<string, List<double>> avaluacio = new Dictionary<string, List<double>>();
            List<double> notes = new List<double>();

            string nom;
            for (int i = 0; i < 2; i++)
            {
                notes.Clear();
                Console.WriteLine("Estas avaluant a un nou alumne");
                Console.WriteLine("Com es diu ?");
                nom = Console.ReadLine();

                for (int l = 0; l < 3; l++)
                {
                    Console.WriteLine("Que va treure en {0} en la prova {1}(nota entre 0 i 10)?",nom,l);
                    string Knom = Console.ReadLine();
                    double nota = Convert.ToDouble(Knom);
                    notes.Add(nota);
                }

                avaluacio.Add(nom, notes.ToList());
            }

            return avaluacio;
        }

        public static void mostrarinvertit(List<char[]> list)
        {
            string nom = "";
            foreach (char[] i in list)
            {
                foreach (char l in i)
                    nom = l + nom;
                Console.WriteLine(nom);
                nom = "";
            }

            Console.WriteLine("");
        }

        public static List<char[]> desmontar(List<string> ciutats)
        {
            List<char[]> listas = new List<char[]>();
            char[] paja;

            foreach(string i in ciutats)
            {
                paja = i.ToCharArray(0, i.Length);
                listas.Add(paja);
            }

            return listas;
        }

        public static List<string> modificar(List<string> array)
        {
            List<string> noulist = new List<string>();

            foreach(string i in array)
            {
                noulist.Add(i.Replace('a','4'));
            }

            return noulist;
            
        }

        public static List<string> ordenar(List<string> array)
        {
            array = array.OrderBy(array => array).ToList();

            return array;
        }

        public static List<string> omplir()
        {
            List<string> array = new List<string>();

            Console.WriteLine("Quina ciutat vols anar?");
            ciutat1 = Console.ReadLine();

            Console.WriteLine("Quina ciutat vols anar?");
            ciutat2 = Console.ReadLine();

            Console.WriteLine("Quina ciutat vols anar?");
            ciutat3 = Console.ReadLine();

            Console.WriteLine("Quina ciutat vols anar?");
            ciutat4 = Console.ReadLine();

            Console.WriteLine("Quina ciutat vols anar?");
            ciutat5 = Console.ReadLine();

            Console.WriteLine("Quina ciutat vols anar?");
            ciutat6 = Console.ReadLine();

            array.Add(ciutat6);
            array.Add(ciutat5);
            array.Add(ciutat4);
            array.Add(ciutat3);
            array.Add(ciutat2);
            array.Add(ciutat1);

            return array;
        }

        public static void mostrar(List<string> array)
        {
            foreach(string i in array)
                Console.WriteLine("Has ficat : {0} ",i);

            Console.WriteLine("");
        }
    }
}
