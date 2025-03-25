using System.Diagnostics;
namespace prove_10;

public class PerformanceMeasurement
{
    public static void MeasurePerformance()
    {
        var queue = new LQueue<int>(1000000);
        Stopwatch stopwatch = new Stopwatch();

        // Measure Enqueue (10)
        stopwatch.Start();
        for (int i = 0; i < 10; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time(10): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Enqueue (100)
        stopwatch.Start();
        for (int i = 0; i < 100; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time(100): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Enqueue (1000)
        stopwatch.Start();
        for (int i = 0; i < 1000; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time(1000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Enqueue (10000)
        stopwatch.Start();
        for (int i = 0; i < 10000; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time(10000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Enqueue (100000)
        stopwatch.Start();
        for (int i = 0; i < 100000; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time(100000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Enqueue (1000000)
        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time(1000000): " + stopwatch.ElapsedMilliseconds + " ms");



        // Measure Peek (10)
        stopwatch.Restart();
        for (int i = 0; i < 10; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time(10): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek (100)
        stopwatch.Restart();
        for (int i = 0; i < 100; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time(100): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek (1000)
        stopwatch.Restart();
        for (int i = 0; i < 1000; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time(1000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek (10000)
        stopwatch.Restart();
        for (int i = 0; i < 10000; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time(10000): " + stopwatch.ElapsedMilliseconds + " ms");
        
        // Measure Peek (100000)
        stopwatch.Restart();
        for (int i = 0; i < 100000; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time(100000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek (1000000)
        stopwatch.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time(1000000): " + stopwatch.ElapsedMilliseconds + " ms");



        // Measure Contains (10)
        stopwatch.Restart();
        for (int i = 0; i < 10; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time(10): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains (100)
        stopwatch.Restart();
        for (int i = 0; i < 100; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time(100): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains (1000)
        stopwatch.Restart();
        for (int i = 0; i < 1000; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time(1000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains (10000)
        stopwatch.Restart();
        for (int i = 0; i < 10000; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time(10000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains (100000)
        stopwatch.Restart();
        for (int i = 0; i < 100000; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time(100000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains (1000000)
        stopwatch.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time(1000000): " + stopwatch.ElapsedMilliseconds + " ms");





        // Measure Dequeue (10)
        stopwatch.Restart();
        for (int i = 0; i < 10; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time(10): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue (100)
        stopwatch.Restart();
        for (int i = 0; i < 100; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time(100): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue (1000)
        stopwatch.Restart();
        for (int i = 0; i < 1000; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time(1000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue (10000)
        stopwatch.Restart();
        for (int i = 0; i < 10000; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time(10000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue (100000)
        stopwatch.Restart();
        for (int i = 0; i < 100000; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time(100000): " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue (1000000)
        stopwatch.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time(1000000): " + stopwatch.ElapsedMilliseconds + " ms");
    }
}