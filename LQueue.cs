namespace prove_10;

public class LQueue<T>
{
    // Create List and Variables to be used throughout functions in the class
    private List<T> _queue = new List<T>();
    private int _size;
    private int _capacity;

    // Establish variable data.
    public LQueue(int capacity)
    {
        _size = 0;
        _capacity = capacity;
    }
    
    // Add an item to a Queue and increment the value of _size by one to account for the addition of an item to the queue 
    public void Enqueue (T item)
    {
        _queue.Add(item);
        _size++;
    }

    // Removes an item from the queue and returns the value of the removed item. Reduce the value of _size by one to account for
    // the item being removed from the queue therefore the queue size is smaller. Using the RemoveAt() function built into the
    // List<> library we can remove the first item in the queue and have everything moved forward one position in the List<>
    // making the item in index 1 now be in index 0 position.
    public T Dequeue() 
    {
        // If the _size is zero that means the queue is empty so throw an exception to the terminal.
        if (IsEmpty())
        {
            throw new Exception("Queue is empty.");
        }
        else
        {
            // put the item at the front of the queue into a temp variable and then change the location of the frot of the queue to
            // simulate removing the item, finally return the temp variable.
            T item = _queue[0];
            _queue.RemoveAt(0);
            _size--;
            return item;
        }
    }

    // Looks at the item at the front of the queue and return it.
    public T Peek()
    {
        // If the _size is zero that means the queue is empty so throw an exception to the terminal.
        if (IsEmpty())
        {
            throw new Exception("Queue is empty.");
        }
        else
        {
            // Return the item at the front of the queue.
            return _queue[0];
        }
    }

    // Check to see if the queue contains a certain item then return with a True or False.
    public bool Contains(T item)
    {
        return _queue.Contains(item);
    }

    // Convert an item in the queue into a string that can be displayed to the console.
    public String toString(int i)
    {
        // If the _size is zero that means the queue is empty so throw an exception to the terminal.
        if(_queue[i] == null)
        {
            throw new Exception("_queue contains null");
        }
        else
        {
            // Return the item in the queue based on index location and convert it to a string.
            return $"{_queue[i]}";
        }
    }

    // Checks with the _size variable to see if the queue is empty.
    public bool IsEmpty()
    {
        return _size == 0;
    }

    // Gets the value from _size variable.
    public int Size()
    {
        return _size;
    }

    // Get the value from _capacity variable.
    public int Capacity()
    {
        return _capacity;
    }
}