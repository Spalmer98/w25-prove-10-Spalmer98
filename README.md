# W10 Prove: Individual Assignment
## Test Cases
#### Test Case 1
**Add items to queue and check if full**

Expected output:
* Size: 5
* 1
* 2
* 3
* 4
* 5

#### Test Case 2
**Add then remove item from queue**

Expected output:
* 1
* 3
* 5 
* 7
* 9
* 1
* 5
* 9
* Queue is empty.

#### Test Case 3
**Add item then peek at the first item in queue**

Expected output:
* 1
* 3
* 5
* 7
* 9 
* 1
* 5
* Queue is empty.

#### Test Case 4
**Add item then check to see if the queue contains an item**

Expected output:
* 1
* 7
* 6
* 9
* False
* True
* True
* False

#### Performance Measurements

|   Test   |      1     |      2     |      3     |      4     |      5     |     Average    |
|:--------:|:----------:|:----------:|:----------:|:----------:|:----------:|:--------------:|
|  Enqueue |    3 ms    |    3 ms    |    3 ms    |    3 ms    |    4 ms    |     3.2 ms     |
|   Peek   |    5 ms    |    5 ms    |    5 ms    |    5 ms    |    5 ms    |      5 ms      |
| Contains |   354 ms   |   348 ms   |   358 ms   |   389 ms   |   356 ms   |     361 ms     |
|  Dequeue |  33877 ms  |  33111 ms  |  33216 ms  |  33165 ms  |  32927 ms  |   33259.2 ms   |

Not sure if I've programmed the removal in Dequeue correctly but it seems to be the bottleneck of this code. Everything else runs fairly smoothly but contains and dequeue being O(n) really slows the execution down.