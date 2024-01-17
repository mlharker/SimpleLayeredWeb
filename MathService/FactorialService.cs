namespace MathService;

public class FactorialService
{
    public int Factorial(int i)
    {
        if (i == 0 || i==1)
            return 1;
        else
            return i * Factorial(i - 1);
    }
}
