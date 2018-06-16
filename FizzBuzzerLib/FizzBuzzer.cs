using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzerLib
{
  public class FizzBuzzer
  {
    public void Calculate(List<DivisiblePhrase> divisiblePhrases, int count, Action<string> outputStream)
    {
      for (var i = 1; i <= count; i++)
      {
        // Check each divisiblity and spit out the corresponding phrase
        StringBuilder toReturn = new StringBuilder();
        divisiblePhrases.ForEach((DivisiblePhrase obj) =>
        {
          if (i % obj.divisibleBy == 0)
          {
            toReturn.Append(obj.phrase);
          }
        });

        if (toReturn.Length == 0)
        {
          toReturn.Append(i);
        }
        outputStream(toReturn.ToString());
      }
    }
  }

  public class DivisiblePhrase
  {
    public DivisiblePhrase(string phrase, int divisibleBy)
    {
      this.phrase = phrase;
      this.divisibleBy = divisibleBy;
    }
    public string phrase { get; private set; }
    public int divisibleBy { get; private set; }
  }
}
