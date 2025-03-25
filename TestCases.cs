using System.Runtime.CompilerServices;

namespace prove_10;

public class TestCases
{
    public static void Run()
    {
        Console.WriteLine("==================Test Caes==================\n");

        Console.WriteLine("==== Test Case 1 ====");
        // Add items to queue  
        var item = new LQueue<int>(3);
        item.Enqueue(1);
        item.Enqueue(3);
        item.Enqueue(5);
        item.Enqueue(7);
        item.Enqueue(9);

        Console.WriteLine($"Size: {item.Size()}");
        for(int i = 0; i < item.Size(); i++)
        {
            Console.WriteLine(item.toString(i));
        }
        // Expected output:
        // Size: 5
        // 1
        // 3
        // 5
        // 7
        // 9

        Console.WriteLine("==== Test Case 2 ====");
        // Remove item from queue returning the removed item to the console. Remove another item this time with no return before 
        // removing another item with a return. Repeat this a couple more times before removing the rest of the items and triggering
        // the try/catch statement that posts "Queue is empty." to the console. 
        Console.WriteLine(item.Dequeue());
        item.Dequeue();
        Console.WriteLine(item.Dequeue());
        item.Dequeue();
        Console.WriteLine(item.Dequeue());
        try
        {
            Console.WriteLine(item.Dequeue());
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        // Expected output:
        // 1
        // 5
        // 9 
        // Queue is empty.

        Console.WriteLine("==== Test Case 3 ====");
        // Add item then peek at the first item in queue, then remove two more items and peek at the next item before removing
        // the rest of the items and triggering the try/catch statment. 
        item.Enqueue(1);
        item.Enqueue(5);
        item.Enqueue(9);
        item.Enqueue(3);
        item.Enqueue(7);
        Console.WriteLine($"Size: {item.Size()}");
        for(int i = 0; i < item.Size(); i++)
        {
            Console.WriteLine(item.toString(i));
        }
        Console.WriteLine(item.Peek());
        item.Dequeue();
        item.Dequeue();
        Console.WriteLine(item.Peek());
        while(item.Size() != 0)
        {
            item.Dequeue();
        }
        try
        {
            Console.WriteLine(item.Peek());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        // Expected output:
        // Size: 5
        // 1
        // 5
        // 9
        // 3
        // 7 
        // 1
        // 9
        // Queue is empty.

        Console.WriteLine("==== Test Case 4 ====");
        // Add items to queue and display all the items in the queue, then check to see if the queue contains specific items. 
        // Remove one of the items from the queue and check for it again.
        item.Enqueue(3);
        item.Enqueue(9);
        item.Enqueue(7);
        for(int i = 0; i < item.Size(); i++)
        {
            Console.WriteLine(item.toString(i));
        }
        Console.WriteLine(item.Contains(4));
        Console.WriteLine(item.Contains(7));
        Console.WriteLine(item.Contains(3));
        item.Dequeue();
        Console.WriteLine(item.Contains(3));
        // Expected output:
        // 3
        // 9
        // 7
        // False
        // True
        // True
        // False

        Console.WriteLine("==== Test Case 5 ====");
        // Performance tests to calculate speed of each main function's execution.
        PerformanceMeasurement.MeasurePerformance();
    }
}