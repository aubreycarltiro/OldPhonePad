using System;
using System.Linq;
using System.Collections;
class Program
{
    public static void Main()
    {
        //create a dictionary
        Dictionary<int, string> keyPad = new Dictionary<int, string>();

        //add items to dictionary
        keyPad.Add(2, "A");
        keyPad.Add(22, "B");
        keyPad.Add(222, "C");

        keyPad.Add(3, "D");
        keyPad.Add(33, "E");
        keyPad.Add(333, "F");

        keyPad.Add(4, "G");
        keyPad.Add(44, "H");
        keyPad.Add(444, "I");

        keyPad.Add(5, "J");
        keyPad.Add(55, "K");
        keyPad.Add(555, "L");

        keyPad.Add(6, "M");
        keyPad.Add(66, "N");
        keyPad.Add(666, "O");

        keyPad.Add(7, "P");
        keyPad.Add(77, "Q");
        keyPad.Add(777, "R");
        keyPad.Add(7777, "S");

        keyPad.Add(8, "T");
        keyPad.Add(88, "U");
        keyPad.Add(888, "V");

        keyPad.Add(9, "W");
        keyPad.Add(99, "X");
        keyPad.Add(999, "Y");
        keyPad.Add(9999, "Z");

        //get userInput
        Console.Write("Input: ");
        
        //store
        string userInput = Console.ReadLine();
        
        //split userInput into array
        string[] splitInput = userInput.Split(" ");
        //validate userInput
        bool userInputisValid = true;

        var userOutput = "";

        //output
        foreach (string inputNum in splitInput)
        {
            if (int.TryParse(inputNum, out int key) && keyPad.ContainsKey(key))
            {
                userOutput = userOutput + keyPad[key];
            } else { userInputisValid = false;break;}
        }
        
        //output
        if (userInputisValid)
        {
            Console.WriteLine($"Output: {userOutput}");
        } else { Console.WriteLine("Output: ????");}

    }

}