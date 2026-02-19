class Program
{
    static void Main()
    {
        List<Action> actions = new List<Action>();

        for (int i = 1; i <= 5; i++)
        {
           
            int temp = i;

            actions.Add(() => Console.WriteLine(temp));
        }

        
        Console.WriteLine("Результат виконання:");
        foreach (var action in actions)
        {
            action();
        }
    }
}