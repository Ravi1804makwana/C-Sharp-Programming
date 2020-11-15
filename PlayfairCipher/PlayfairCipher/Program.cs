using System;
using System.Collections.Generic;
namespace PlayfairCipher
{
    class Program
    {
        /**
         *
         *  Ravikumar Makwana
         *  Aim: To Implement Playfair Cipher
         *  
         */
        static void Main(string[] args)
        {
            Console.Write("Please enter the plaintext: ");
            string plainText = Console.ReadLine().ToLower();
            Console.Write("Please enter the key: ");
            string key = Console.ReadLine().ToLower();
            
            var keyString = new List<char>();
            var keyMatrix = new char[5, 5];

            //process key
            foreach (var item in key)
            {
                if (!keyString.Contains(item))
                    keyString.Add(item);
            }
            for(int i=0;i<=25;i++)
            {
                if (!keyString.Contains((char)('a' + i)))
                    keyString.Add((char)('a' + i));
            }
            keyString.Remove('j');
            
            // construct Key Matrix
            int c = 0;
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                    keyMatrix[i, j] = keyString[c++];
            }

            Console.WriteLine("\n*** Playfair Cipher ***\n");
            
            Console.WriteLine("Key (5x5 key matrix):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(keyMatrix[i, j] + " ");
                Console.WriteLine();
            }
            
            // process plaintext
            for(int i=0;i<plainText.Length-1;i++)
            {
                if (plainText[i] == plainText[i + 1])
                    plainText = plainText.Insert(i + 1, "x");
                i++;
            }
            if(plainText.Length%2!=0)
                plainText += "x";

            Console.WriteLine("\n*** Encryption Process ***\n");
            Console.WriteLine("Plaintext : "+plainText);

            string cipherText = "";
            int x1=0, y1=0, x2=0, y2=0;

            //process Ciphertext
            for(int i=0;i<plainText.Length;i++)
            {
                char c1 = plainText[i];
                char c2 = plainText[++i];

                for(int j=0;j<5;j++)
                {
                    for(int k=0;k<5;k++)
                    {
                        if(keyMatrix[j,k]==c1)
                        {
                            x1 = j;
                            y1 = k;
                        }
                        if(keyMatrix[j,k]==c2)
                        {
                            x2 = j;
                            y2 = k;
                        }
                    }
                }
                if(y1==y2)
                {
                    cipherText += (char)keyMatrix[(++x1)%5, y1];
                    cipherText += (char)keyMatrix[(++x2)%5, y1];
                }
                else if (x1 == x2)
                {
                    cipherText += (char)keyMatrix[x1, (++y1)%5];
                    cipherText += (char)keyMatrix[x1, (++y2)%5];
                }
                else
                {
                    cipherText += (char)keyMatrix[x1, y2];
                    cipherText += (char)keyMatrix[x2, y1];
                }
            }
            
            Console.WriteLine("Ciphertext: "+cipherText);
            
            Console.ReadKey();
        }
    }
}
