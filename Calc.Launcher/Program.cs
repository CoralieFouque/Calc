﻿using System;

namespace Calc.Launcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You must provide a command line argument.");
                return;
            }

            var interpreter = CreateInterpreter();
            var ast = new Parser().Parse(new Tokenizer().Tokenize(args[0]));
            ast.Accept(interpreter);
            Console.WriteLine(interpreter.Result);

        }
    }
}
