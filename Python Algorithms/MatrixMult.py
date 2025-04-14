import time
import random

sizes = [10, 50, 100, 250, 500]
for size in sizes:
    print(f"Column and Row size is: {size}\n")
    rows = size
    cols = size

    a = [[random.randint(0, 100) for _ in range(cols)] for _ in range(rows)]
    b = [[random.randint(0, 100) for _ in range(cols)] for _ in range(rows)]
    c = [[0 for _ in range(cols)] for _ in range(rows)]

    start_time = time.perf_counter() 

    for i in range(rows):
        for j in range(cols):
            for k in range(cols):
                c[i][j] += a[i][k] * b[k][j]

    end_time = time.perf_counter()
    execution_time = end_time - start_time
    print(f"Execution time: {execution_time:.4f} seconds")
    print("\n")