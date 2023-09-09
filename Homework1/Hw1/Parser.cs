﻿namespace Hw1;

public static class Parser
{
    public static void ParseCalcArguments(
        string[] args,
        out double val1,
        out CalculatorOperation operation,
        out double val2
    )
    {
        if (!(IsArgLengthSupported(args)))
            throw new ArgumentException("Too many arguments");
        if (!Double.TryParse(args[0], out val1))
            throw new ArgumentException("First argument is not a real number");
        operation = ParseOperation(args[1]);
        if (operation == CalculatorOperation.Undefined)
            throw new InvalidOperationException("Undefined operation");
        if (!Double.TryParse(args[2], out val2))
            throw new ArgumentException("Third argument is not a real number");
    }

    private static bool IsArgLengthSupported(string[] args) => args.Length == 3;

    private static CalculatorOperation ParseOperation(string arg) =>
        arg switch
        {
            "+" => CalculatorOperation.Plus,
            "-" => CalculatorOperation.Minus,
            "*" => CalculatorOperation.Multiply,
            "/" => CalculatorOperation.Divide,
            _ => CalculatorOperation.Undefined
        };
}
