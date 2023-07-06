using System;

//ref link:https://www.youtube.com/watch?v=L6R08ajgZpU&list=PL9B5E4C37F7B234A8&index=1
//  Yield Statement 

class MainClass
{
    static Random rand = new Random(); // one static random required
    static IEnumerable<int> GetRandomNumbers(int count)
    {
        //List<int> ints = new List<int>(count); // List requires knowledge in DATA STRUCTURE
        for (int i = 0; i < count; i++)
            //ints.Add(rand.Next());    // list
            yield return rand.Next();   // yield 
        //return ints;  //list
    }
    static void Main()
    {
        foreach(int num in GetRandomNumbers(10))
            Console.WriteLine(num);
    }
}