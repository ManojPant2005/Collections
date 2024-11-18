namespace Collections
{
    public class ArrayList
    {
        public void Main(string[] args)
        {
            //Array
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[0]); // Output: 1


            //List
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");
            Console.WriteLine(names[1]); // Output: Bob


            //Dictionary

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages["Alice"] = 30;
            ages["Bob"] = 25;
            Console.WriteLine(ages["Alice"]); // Output: 30


            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Alice");
            queue.Enqueue("Bob");
            Console.WriteLine(queue.Dequeue()); // Output: Alice

            Stack<string> stack = new Stack<string>();
            stack.Push("Plate 1");
            stack.Push("Plate 2");
            Console.WriteLine(stack.Pop()); // Output: Plate 2

        }

    }
}
