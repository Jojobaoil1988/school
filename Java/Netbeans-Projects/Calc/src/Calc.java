/**
 * Calc.java
 *
 * @author Jannis Guhl
 * @version 1.0 
 * Simple calculator for +, -, * and / operations
 */
import java.util.StringTokenizer;
import java.util.Stack;

public class Calc
{
    private StringTokenizer aTokenizer;
    private Stack<Float> stack = new Stack<Float>();
    String nextToken;
    char mathOperator;
    
    /**
     * Calculating the result of a given formula
     * @param postfix given formula in postfix notation
     * @return the result of the calculation
     */
    public float computePostfix(String postfix)
    {
        aTokenizer = new StringTokenizer(postfix, "+-*/ ", true);
        while(aTokenizer.hasMoreElements())
        {
            nextToken = aTokenizer.nextToken();
            mathOperator = nextToken.charAt(0);
            
            switch(mathOperator)
            {
                case '+': 
                    calculate();
                    break;
                case '-':
                    calculate();
                    break;
                case '*':
                    calculate();
                    break;
                case '/':
                    calculate();
                    break;
                case ' ':
                    break;
                default:
                    stack.push(Float.valueOf(nextToken));
                    break;
            }
        }
        return stack.pop();
    }
    
    private void calculate()
    {
        float number1, number2, result = 0;
        
        if (stack.empty())
        {
            return;
        }
        number2 = stack.pop();
        if (stack.empty())
        {
            return;
        }
        number1 = stack.pop();
        
        switch(mathOperator)
        {
            case '+':
                result = number1 + number2;
                break;
            case '-':
                result = number1 - number2;
                break;
            case '*':
                result = number1 * number2;
                break;
            case '/':
                result = number1 / number2;
                break;
            default:
                throw new UnsupportedOperationException();
        }
        
        stack.push(result);
    }
    
    
}
