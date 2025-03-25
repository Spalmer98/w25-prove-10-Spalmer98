namespace prove_10;

public class LQueue<T> where T: new()
{
    // Create Variable
    private List<T> _queue = new List<T>();
    private int _size;
    private int _capacity;

    // Establish variable data.
    public LQueue(int capacity)
    {
        _size = 0;
        _capacity = capacity;
    }
    
    // Add item to Queue
    public void Enqueue (T item)
    {
        _queue.Add(item);
        _size++;
    }

    // Removes an item from the queue and returns the value of the removed item.
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

    // Looks at the item at the front of the queue.
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

    // Check to see if the queue contains a certain item then return it.
    public bool Contains(T item)
    {
        bool results = false;
        if (_queue.Contains(item))
            results = true;
        return results;
    }

    // Convert an item in the queue into a string that can be displayed to the console.
    public String ToString(int i)
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

    public int Capacity()
    {
        return _capacity;
    }
}