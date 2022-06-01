using System;

namespace Collect;

class Collection

{
    internal void LearnArrays()
    {
        // 1D
        byte[] ages = new byte[20];
        ages[0] = 23;
        ages[1] = 24;
        ages[2] = 25;
        ages[3] = 26;
        ages[4] = 27;

        float[] numbers = { 45, 67, 78 };

        // 2D
        decimal[,] mat = new decimal[3, 4];
        mat[0, 0] = 34;
        mat[0, 1] = 54;
        mat[0, 3] = 55;

        double[,] table = { { 2, 3 }, { 4, 5 } };


        //  Jagged Array
        string[][] semNames = new string[3][];
        string [] firstSemNames = {"Ram","shyam","Hari","Gopal"};
        string[] secomdSemName = {"Gopal","Sita","Rim","David"};

        System.Console.WriteLine(semNames[0][0]);  
    }
}