using System.Diagnostics;
namespace prove_10;

public class PerformanceMeasurement
{
    public static void MeasurePerformance()
    {
        var queue = new LQueue<int>(1000000);
        Stopwatch stopwatch = new Stopwatch();

        // Measure Enqueue
        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek
        stopwatch.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains
        stopwatch.Restart();
        for (int i = 0; i < 100000; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue
        stopwatch.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}