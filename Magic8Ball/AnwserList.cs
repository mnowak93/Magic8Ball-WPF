using System;
using System.Collections.Generic;

namespace Magic8Ball
{
    class AnwserList
    {
        private Dictionary<int, string> aList = new Dictionary<int, string>()
        {
            {0, "Yes."},
            {1, "No."},
            {2, "It is certain."},
            {3, "Maybe."},
            {4, "It is decidedly so."},
            {5, "Without a doubt."},
            {6, "Yes - definitely."},
            {7, "You may rely on it."},
            {8, "As I see it, yes."},
            {9, "Most likely."},
            {10, "Outlook good."},
            {11, "Signs point to yes."},
            {12, "Reply hazy, try again."},
            {13, "Ask again later."},
            {14, "Better not tell you now."},
            {15, "Cannot predict now."},
            {16, "Concentrate and ask again."},
            {17, "Don't count on it."},
            {18, "My reply is no."},
            {19, "My sources say no."},
            {20, "Outlook not so good."},
            {21, "Very doubtful."},
            {22, "And what do YOU think?"},
            {23, "I don't know, but here have TIE fighter |-o-|"},
            {24, "I don't know, but here have X-wing >[]<"},
        };

        public string ReturnAnwser()
        {
            Random rnd = new Random();
            return aList[rnd.Next(0, 24)];
        }
    }
}
