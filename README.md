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

|   Test   |   10   |  100   |  1000   |   10000  |  100000   |   1000000  |    Average   |
|:--------:|:------:|:------:|:-------:|:--------:|:---------:|:----------:|:------------:|
|  Enqueue |  0 ms  |  0 ms  |   0 ms  |    0 ms  |     0 ms  |      4 ms  |    0.666 ms  |
|   Peek   |  0 ms  |  0 ms  |   0 ms  |    0 ms  |     0 ms  |      3 ms  |      0.5 ms  |
| Contains |  0 ms  |  0 ms  |   0 ms  |    4 ms  |   430 ms  |  45840 ms  |  7712.33 ms  |
|  Dequeue |  0 ms  |  7 ms  |  74 ms  |  737 ms  |  7062 ms  |  33498 ms  |  6896.33 ms  |

Not sure if I've programmed the removal in Dequeue correctly but it seems to be the bottleneck of this code. Everything else runs fairly smoothly but contains and dequeue being O(n) really slows the execution down.