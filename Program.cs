/*
Scrabble from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-13

Give a variable number of words, create a program to output the word with the maximum score, based on the following scoring system: 
The score of a word is calculated based on its character values, according to this table: 
e, a, i, o, n, r, t, l, s, u are equal 1 point 
d, g	2 points 
b, c, m, p	3 points 
f, h, v, w, y 4 points 
k 5 points 
j, x 8 points 
q, z 10 points 

The max length of a word is 10 letters. 

For example: 
input { "This",  "is", "a", "cool" , "Challenge" } 
output : Challenge 
*/

using System;

namespace Scrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[] { "This", "is", "a", "cool", "Challenge" }; // Insert an array of strings to calculate a maximum score

            string inputformated = String.Empty;
            string output = String.Empty;
            int score = 0;
            int maxscore = 0;

            foreach (string s in input)
            {
                foreach (char c in s)
                {
                    score += GetPoints(c);
                }

                inputformated += String.Format($"\"{s}\", ");

                if (score > maxscore) { maxscore = score; output = s; }
            }

            Console.WriteLine("input: { " + $"{inputformated.TrimEnd(',', ' ')}" + " }");
            Console.WriteLine($"output: {output}");
        }

        static int GetPoints(char c)
        {
            int points = 0;
            switch (c)
            {
                case 'e':
                case 'a':
                case 'i':
                case 'o':
                case 'n':
                case 'r':
                case 't':
                case 'l':
                case 's':
                case 'u':
                    points = 1;
                    break;
                case 'd':
                case 'g':
                    points = 2;
                    break;
                case 'b':
                case 'c':
                case 'm':
                case 'p':
                    points = 3;
                    break;
                case 'f':
                case 'h':
                case 'v':
                case 'w':
                case 'y':
                    points = 4;
                    break;
                case 'k':
                    points = 5;
                    break;
                case 'j':
                case 'x':
                    points = 8;
                    break;
                case 'q':
                case 'z':
                    points = 10;
                    break;
            }

            return points;
        }
    }
}