namespace Module5_Collections.Task2_StoreQueue;

public class Task2StoreQueue
{
    public void Run()
    {
        Queue<int> clientQueue = new Queue<int>();
        clientQueue.Enqueue(100);
        clientQueue.Enqueue(200);
        clientQueue.Enqueue(300);

        int sum = 0;

        while (clientQueue.Count > 0)
        {
            Console.WriteLine($"Клиентов в очереди: {clientQueue.Count}");
            sum += clientQueue.Dequeue();
            Console.WriteLine($"Общая сумма покупок: {sum}");
            
            Console.ReadKey();
            Console.Clear();
        }
    }
}