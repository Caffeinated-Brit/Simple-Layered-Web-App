namespace MathService;

public class FactorialService
{
    
    
    public static int CalculateFactorial(int n)
    {
        { 
            if (n == 0) 
                return 1; 
            return n * CalculateFactorial(n - 1); 
        } 
    }
}
