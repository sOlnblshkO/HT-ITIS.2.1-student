using Hw8.Calculator;

namespace Hw8.Parser;

public interface IParser
{
    public string Parse(string val1, string operation, string val2, ICalculator calculator);
}