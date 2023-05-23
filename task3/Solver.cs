class Solver
{
    public static void Main(string[] args)
    {
        string[] operators = new string[4] { "+", "-", "*", "/" };
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');

        Stack stack = new Stack();

        foreach (string i in inputs)
        {
            if (operators.Contains(i))
            {
                if (i == "+")
                {
                    float lastElemInStack = stack.Pop();
                    float preLastElemInStackBeforeDelete = stack.Pop();
                    float numberResultOfCalculation = preLastElemInStackBeforeDelete + lastElemInStack;
                    stack.Push(numberResultOfCalculation);

                }
                else if (i == "-")
                {
                    float lastElemInStack = stack.Pop();
                    float preLastElemInStackBeforeDelete = stack.Pop();
                    float numberResultOfCalculation = preLastElemInStackBeforeDelete - lastElemInStack;
                    stack.Push(numberResultOfCalculation);
                }
                else if (i == "*")
                {
                    float lastElemInStack = stack.Pop();
                    float preLastElemInStackBeforeDelete = stack.Pop();
                    float numberResultOfCalculation = preLastElemInStackBeforeDelete * lastElemInStack;
                    stack.Push(numberResultOfCalculation);
                }
                else if (i == "/")
                {
                    float lastElemInStack = stack.Pop();
                    float preLastElemInStackBeforeDelete = stack.Pop();
                    float numberResultOfCalculation = preLastElemInStackBeforeDelete / lastElemInStack;
                    stack.Push(numberResultOfCalculation);
                }
            }
            else
            {
                float elem = Int32.Parse(i);
                stack.Push(elem);
            }
        }

        float res = stack.Pop();
        Console.WriteLine(res);
    }

    public class Stack
    {
        public float[] items;
        public int countElements = 0;
        public int defaultSize = 10; 

        public Stack()
        {
            items = new float[defaultSize];
        }

        public bool IsEmpty()
        {
            return countElements == 0;
        }

        public void Resize(int newLength)
        {
            float[] tempItems = new float[newLength];
            for (int i = 0; i < countElements; i++)
            {
                tempItems[i] = items[i];
            }
            items = tempItems;
        }

        public void Push(float item)
        {
            if (countElements == items.Length)
            {
                Resize(items.Length + 10);
            }
            items[countElements] = item;
            countElements += 1;
        }

        public float Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack in empty");
            }
            float item = items[--countElements];

            if (countElements > 0 && countElements < items.Length - 10)
            {
                Resize(items.Length - 10);
            }
            return item;
        }


    }
}