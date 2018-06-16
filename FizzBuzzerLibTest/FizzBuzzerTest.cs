using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzzerLib;
using Xunit;

namespace FizzBuzzerLibTest
{
  public class FizzBuzzerTest
  {
    [Fact]
    public void Test15Standard()
    {
      var divisiblePhrases = new List<DivisiblePhrase>();
      divisiblePhrases.Add(new DivisiblePhrase("FIZZ", 3));
      divisiblePhrases.Add(new DivisiblePhrase("BUZZ", 5));
      FizzBuzzer fizzBuzzer = new FizzBuzzer();

      int totalCount = 20;
      int counter = 1;
      fizzBuzzer.Calculate(divisiblePhrases, totalCount, (string output) =>
      {
        if (counter == 15)
        {
          Assert.Equal("FIZZBUZZ", output);
        }
        else if (counter == 8)
        {
          Assert.Equal("8", output);
        }
        counter++;
      });
      Assert.Equal(totalCount + 1, counter);
    }

    [Fact]
    public void Test50Funky()
    {
      var divisiblePhrases = new List<DivisiblePhrase>();
      divisiblePhrases.Add(new DivisiblePhrase("FOO", 4));
      divisiblePhrases.Add(new DivisiblePhrase("BAR", 5));
      divisiblePhrases.Add(new DivisiblePhrase("BAZ", 10));
      FizzBuzzer fizzBuzzer = new FizzBuzzer();

      int totalCount = 50;
      int counter = 1;
      fizzBuzzer.Calculate(divisiblePhrases, totalCount, (string output) =>
      {
        if (counter == 20)
        {
          Assert.Equal("FOOBARBAZ", output);
        }
        else if (counter == 19)
        {
          Assert.Equal("19", output);
        }
        counter++;
      });
      Assert.Equal(totalCount + 1, counter);
    }
  }
}
