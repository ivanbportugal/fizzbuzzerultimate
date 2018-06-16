using System;
using System.Collections.Generic;
using FizzBuzzerLib;

namespace FizzBuzzerUltimate
{
  class Program
  {
    static void Main(string[] args)
    {
      var divisiblePhrases = new List<DivisiblePhrase>();
      divisiblePhrases.Add(new DivisiblePhrase("FIZZ", 3));
      divisiblePhrases.Add(new DivisiblePhrase("BUZZ", 5));
      FizzBuzzer fizzBuzzer = new FizzBuzzer();
      fizzBuzzer.Calculate(divisiblePhrases, 20, (string output) =>
      {
        Console.WriteLine(output);
      });
    }
  }
}
