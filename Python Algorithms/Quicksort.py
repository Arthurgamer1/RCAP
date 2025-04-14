import time
import random

def partition(array, first, last):
    pivot = array[last]
    
    i = first - 1
    
    for j in range(first, last):
        if array[j] <= pivot:
            i += 1
            (array[i], array[j]) = (array[j], array[i])
    
    (array[i+1], array[last]) = (array[last], array[i+1])
    return i + 1

def quicksort(array, first, last):
    if first < last:
        pi = partition(array, first, last)
        quicksort(array, first, pi - 1)
        quicksort(array, pi + 1, last)
        

array_sizes = [10, 100, 1000, 10000, 100000]
arrays = []
for size in array_sizes:
    for _ in range(3): # Makes 3 arrays for each sample size and randomly fills it with values
        arr = [random.randint(0, 1000000) for _ in range(size)]
        arrays.append(arr)

for arr in arrays:
    size = len(arr)
    print(f"Array Size: {size}\n")
    start_time = time.perf_counter() 
    quicksort(arr, 0, size - 1)
    end_time = time.perf_counter()
    execution_time = end_time - start_time
    print(f"Execution time: {execution_time:.4f} seconds")
    print("\n")