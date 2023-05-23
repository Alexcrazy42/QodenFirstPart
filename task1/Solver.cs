class Solver
{
    public static void Main(string[] args)
    {
        int count = Int32.Parse(Console.ReadLine());
        HashTable hashTable = new HashTable(count);


        string[] numbers;

        numbers = Console.ReadLine().Split(' ');
        foreach (string i in numbers)
        {
            int num = Int32.Parse(i);
            hashTable.Insert(num);
        }

        for (int i = 0; i < hashTable.Count; i++)
        {
            Console.Write($"{i}: ");
            var current = hashTable.Values[i].head;
            while (current != null)
            {
                Console.Write($"{current.Data} ");
                current = current.Next;
            }
            Console.WriteLine();

        }


    }


    class HashTable
    {
        public HashTable(int count)
        {
            Values = new LinkedList[count];
            for (int i = 0; i < count; i++)
            {
                Values[i] = new LinkedList();
            }
            Count = count;
        }

        public LinkedList[] Values;
        public int Count;

        public void Insert(int newValue)
        {
            int index = newValue % Count;
            Values[index].Insert(newValue);
        }
    }

    public class ListNode
    {
        public ListNode(int data)
        {
            Data = data;
        }

        public int Data { get; set; }
        public ListNode Next { get; set; }
    }

    public class LinkedList
    {
        public ListNode head;
        public ListNode tail;


        public void Insert(int data)
        {
            ListNode node = new ListNode(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;

        }
    }
}