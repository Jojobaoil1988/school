/*
 * ADS_02 (Telematics)
 */

import java.util.*;

/**
 * Class to translate an arithmetic expression from infix notation to postfix
 * notation
 *
 * @author Janett Mohnke (adapted from Balzert)
 * @version 1.0
 */
class Notation {
    //Attributs

    private StringTokenizer aTokenizer;
    private Stack<String> aStack = new Stack<String>();
    String nextToken, stackToken;
    String result = "";
    char operatorAsChar, tokenChar;
    //Operations

    /**
     * returns the postfix notion of input Note: A correct infix expression is
     * assumed.
     *
     * @param input contains an arithmetics expression in infix notion
     * @return a String which contains the postfix notion of input
     */
    public String getPostfix(String input) {
        aTokenizer = new StringTokenizer(input, "+-*/()", true);
        result = "";
        /* decompose the input string "input" as discussed in script
         * "02_Datenstrukturen2.pdf"
         */
        do {
            nextToken = aTokenizer.nextToken();
            operatorAsChar = nextToken.charAt(0);
            switch (operatorAsChar) {
                case '+':
                case '-':
                    processPlusMinus();
                    break;
                case '*':
                case '/':
                    processMulDiv();
                    break;
                case '(':
                    aStack.push(nextToken);
                    break;
                case ')':
                    boolean isLeftPar; //left parenthesis
                    do {
                        stackToken = (String) aStack.pop();
                        isLeftPar = stackToken.equals("(");
                        if (!isLeftPar) {
                            result = result + stackToken;
                            if (isOperator(stackToken.charAt(0))) {
                                result += " ";
                            }
                        }
                    } while (!isLeftPar);
                    break;
                default: //next Token is a number
                    result = result + nextToken + " ";
                    break;
            }
        } while (aTokenizer.hasMoreElements());
        //There still might be operations on stack aStack.
        //Append them to the result string.
        while (!aStack.empty()) {
            result = result + aStack.pop() + " ";
        }
        return result;
    }

    /**
     * handles plus and minus operations
     */
    private void processPlusMinus() {
        boolean priority = false; //empty stack until next "("
        while (!aStack.empty() && !priority) {
            stackToken = aStack.peek();
            tokenChar = stackToken.charAt(0);
            if (isOperator(tokenChar)) {
                result = result + aStack.pop() + " ";
            } else {
                priority = true;
            }
        }
        aStack.push(nextToken);
    }

    /**
     * handles multiplication and division operations
     */
    private void processMulDiv() {
        boolean priority = false; //empty stack until next "("
        while (!aStack.empty() && !priority) {
            stackToken = aStack.peek();
            tokenChar = stackToken.charAt(0);
            if ((tokenChar == '*') || (tokenChar == '/')) {
                result = result + aStack.pop() + " ";
            } else {
                priority = true;
            }
        }
        aStack.push(nextToken);
    }

    /**
     * just checks whether the parameter chracter is an operation
     *
     * @param ch the char which has to be tested
     */
    private boolean isOperator(char ch) {
        return ch == '+' || ch == '-' || ch == '*' || ch == '/';
    }
}
