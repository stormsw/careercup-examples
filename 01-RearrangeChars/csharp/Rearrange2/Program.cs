namespace RearrangeChars
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input = "aaabc";
            if (args != null && args.Length > 0)
            {
                input = args[0];
            }
            Console.WriteLine("Rearrange characters in a string so that no character repeats twice.\n\n");
            Console.WriteLine("Input: " + input);
            Console.WriteLine("Output: "+(new CharacterArranger(input)).arrange());
        }
    }
}
