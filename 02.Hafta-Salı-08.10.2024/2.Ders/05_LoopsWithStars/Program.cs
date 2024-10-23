﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yanyana 10 tane yıldız oluşturma
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırında 10 tane yıldız olsun.

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}


            #endregion

            #region Ters DikÜçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve Ters Dik Üçgen Beraber

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4;  k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Baklava Dilimi

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n-1; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = n-1; i >= 1; i--)
            //{
            //    for (int j = n-1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*"); 
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi Kendi Denemem
            //int n = 8;
            ////üst taraf
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            ////alt taraf
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region Piramit
            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{

            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit

            //int n = 5;
            //for (int i = n; i >= 1; i--)

            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // yıldızlar 
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {

            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}
            #endregion


            Console.Read();
            
        }
    }
}
