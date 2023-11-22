﻿namespace Hw1;

public static class Parser
{
    public static void ParseCalcArguments(string[] args, 
        out double val1, 
        out CalculatorOperation operation, 
        out double val2)
    {
        if (!IsArgLengthSupported(args))
            throw new ArgumentException($"Need 3 arguments, was given {args.Length}");

        if (!(double.TryParse(args[0], out _) && double.TryParse(args[2], out _)))
            throw new ArgumentException($"Wrong arguments, expected numbers, was given {args[0]} and {args[2]}");

        val1 = double.Parse(args[0]);
        operation = ParseOperation(args[1]);
        val2 = double.Parse(args[2]);
    }

    private static bool IsArgLengthSupported(string[] args) => args.Length == 3;

    private static CalculatorOperation ParseOperation(string arg)
    {
        return arg switch
        {
            "+" => CalculatorOperation.Plus,
            "-" => CalculatorOperation.Minus,
            "*" => CalculatorOperation.Multiply,
            "/" => CalculatorOperation.Divide,
            _ => throw new InvalidOperationException($"Expected operation, was given {arg}")
        };
    }
}