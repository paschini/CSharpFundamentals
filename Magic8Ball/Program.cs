// using top level statements, so this is unnecessary:
// namespace Magic8Ball;
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello, World!");
//     }
// }

using Magic8Ball;

Console.WriteLine();
foreach (var s in args)
{
    Console.Write(s);
    Console.Write(' ');
}

Console.WriteLine();

// var utils = new Utilities();
// await utils.ShowConsoleAnimation();

// In this case, static class is more appropriate, since it doesn't have any instance members, so we won't require object memory allocation.'
await Utilities.ShowConsoleAnimation();

string[] answers =
[
    "It is certain.", "Reply hazy, try again.", "Don't count on it.",
    "It is decidedly so.", "Ask again later.", "My reply is no.",
    "Without a doubt.", "Better not tell you now.", "My sources say no.",
    "Yes – definitely.", "Cannot predict now.", "Outlook not so good.",
    "You may rely on it.", "Concentrate and ask again.", "Very doubtful.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
];

string[] onlyNegatives =
[
    "Don't count on it.",
    "My reply is no.",
    "Better not tell you now.",
    "My sources say no.",
    "Cannot predict now.",
    "Outlook not so good.",
    "Very doubtful.",
    "No!",
    "Nej!",
    "Niet!"
];

if (args[0] == "ask" && args.Length > 1)
{
    // I'm not sure I like top level statements... Brain too rotted in C?
    var negativeIndex = new Random().Next(answers.Length - 1);
    Console.WriteLine(onlyNegatives[negativeIndex]);
}

var index = new Random().Next(answers.Length - 1);
Console.WriteLine(answers[index]);