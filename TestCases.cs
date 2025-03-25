using System.Runtime.CompilerServices;

namespace prove_10;

public class TestCases
{
    public static void Run()
    {
        Console.WriteLine("==================Test Caes==================\n");

        Console.WriteLine("==== Test Case 1 ====");
        // Add items to queue and check if full   
        var item = new LQueue<int>(3);
        item.Enqueue(1);
        item.Enqueue(2);
        item.Enqueue(3);
        item.Enqueue(4);
        item.Enqueue(5);


        Console.WriteLine($"Size: {item.Size()}");

        item.GetItem();
        // Expected output:
        // Size: 5
        // 1
        // 2
        // 3
        // 4
        // 5

        Console.WriteLine("==== Test Case 2 ====");
        // Add then remove item from queue
        item = new LQueue<int>(3);
        item.Enqueue(1);
        item.Enqueue(3);
        item.Enqueue(5);
        item.Enqueue(7);
        item.Enqueue(9);

        item.GetItem();

        Console.WriteLine(item.Dequeue());
        item.Dequeue();
        Console.WriteLine(item.Dequeue());
        item.Dequeue();
        Console.WriteLine(item.Dequeue());
        Console.WriteLine(item.Dequeue());
        // Expected output:
        // 1
        // 3
        // 5 
        // 7
        // 9
        // 1
        // 5
        // 9
        // Queue is empty.

        Console.WriteLine("==== Test Case 3 ====");
        // Add item then peek at the first item in queue
        item = new LQueue<int>(5);
        item.Enqueue(1);
        item.Enqueue(3);
        item.Enqueue(5);
        item.Enqueue(7);
        item.Enqueue(9);
        item.GetItem();
        Console.WriteLine(item.Peek());
        item.Dequeue();
        item.Dequeue();
        Console.WriteLine(item.Peek());
        item.DequeueAll();
        Console.WriteLine(item.Peek());
        // Expected output:
        // 1
        // 3
        // 5
        // 7
        // 9 
        // 1
        // 5
        // Queue is empty.

        Console.WriteLine("==== Test Case 4 ====");
        // Add item then check to see if the queue contains an item
        item = new LQueue<int>(3);
        item.Enqueue(1);
        item.Enqueue(7);
        item.Enqueue(6);
        item.Enqueue(9);
        item.GetItem();

        Console.WriteLine(item.Contains(4));
        Console.WriteLine(item.Contains(7));
        Console.WriteLine(item.Contains(1));
        item.Dequeue();
        Console.WriteLine(item.Contains(1));

        // Expected output:
        // 1
        // 7
        // 6
        // 9
        // False
        // True
        // True
        // False

        Console.WriteLine("==== Test Case 5 ====");
        PerformanceMeasurement.MeasurePerformance();
    }
}