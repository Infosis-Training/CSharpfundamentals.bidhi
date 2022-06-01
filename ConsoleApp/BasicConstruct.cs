

using System;

class Basic
{
//     public static void Main1()
//     {
//         // LearnConditionals(33);
//         // LearnConditionals(60);
//     }


static void LearnConditionals(byte x)
    {

        if (x < 50) //comparision operators <,>,<=,>=,==,!=,
        {
            Console.WriteLine(x + " is less than 50.");
        }
        else if (x < 70)
        {
            Console.WriteLine(x + "is between 50-70");
        }
        else
        {
            Console.WriteLine("X is greater than 70");
        }
    }

    void LearnSwitch()
    {
        string name = "Bidhi";
        switch (name)
        {
            case "Bidhi":
                // some code
                break;
            case "Ram":
                // some code
                break;
            case "Shyam":
                // some code
                break;
            default:
                // some code
                break;
        }
    }


    internal void LearnLoops()
    {
        for (byte i = 0; i < 5; i++)
        {

            Console.WriteLine(i + ".NET Training");
        }



string[] names = {"Ramesh","David","Anish"};
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }

//         byte j=1;
//         while (j < 5)
//         {
//             Console.WriteLine(j + ".NET Training");
//             j++;
//         }
    }

}