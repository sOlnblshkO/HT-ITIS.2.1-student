﻿using Hw1;

Parser.ParseCalcArguments(args, out var val1, out var operation, out var val2);

Console.WriteLine(Calculator.Calculate(val1, operation, val2));
