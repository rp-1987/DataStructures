using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneProgramADay
{
    public class Others
    {
        public static int iterations = 0;
        public int PostFixOperation(string postFixExpression)
        {                        
            string[] expression = postFixExpression.ToCharArray().Select(c => c.ToString()).ToArray();
            iterations = iterations + expression.Length;
            while(expression.Length > 1)
            {
                iterations++;
                expression = EvaluateExpression(expression);
            }
            return Convert.ToInt32(expression[0]);
        }

        private string[] EvaluateExpression(string[] expression)
        {
            for (int i = 0; i < expression.Length; i++)
            {
                iterations++;
                if (IsOperator(expression[i]))
                {

                    string a = expression[i - 2];
                    string b = expression[i - 1];
                    int res = PerformOperation(Convert.ToInt32(a.ToString()), Convert.ToInt32(b.ToString()), expression[i]);
                    expression[i - 2] = res.ToString();
                    expression = RemoveArrayElements(expression, i);
                    expression = RemoveArrayElements(expression, i - 1);
                    break;
                }
            }
            return expression;
        }

        private string[] RemoveArrayElements(string[] array, int removeIndex)
        {
            List<string> arrayList = array.ToList();
            arrayList.RemoveAt(removeIndex);
            return arrayList.ToArray();
        }

        private bool IsOperator(string c)
        {
            string[] operators = new string[4] { "+", "-", "*", "/" };
            return (operators.Contains(c));
        }

        private int PerformOperation(int a, int b, string operand)
        {
            switch(operand)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    return 0;
            }
        }

        public int PostFixOperationsUsingStack(string postFixExpression)
        {
            string[] expression = postFixExpression.ToCharArray().Select(c => c.ToString()).ToArray();
            iterations = iterations + 7;
            Stack<int> numberStack = new Stack<int>();
            foreach(string s in expression)
            {
                iterations++;
                if (!IsOperator(s))
                    numberStack.Push(Convert.ToInt32(s));
                else
                {
                    int num2 = numberStack.Pop();
                    int num1 = numberStack.Pop();
                    int res = PerformOperation(num1, num2, s);
                    numberStack.Push(res);
                }
            }
            return numberStack.Pop();
        }
    }
}
