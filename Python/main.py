import time

Array = []

number = input("Enter a number: ")


for i in range(5000 * 10 + 1):
    Array.append(i)

# number = 5423

if number == "":
    print("You didn't enter a number")
    pass

if int(number) not in Array:
    print("Number is not in the array")
    pass


current_time = time.time()

start_time_1 = current_time
start_time_2 = current_time
all_time_1 = 0
all_time_2 = 0

def lineare_serach(value):
    global all_time_1, start_time_1
    for i in range(len(Array)):
        if Array[i] == value:
            all_time_1 += (time.time() - start_time_1)
            return "" + str(i) + " " + str(Array[i])
    return "Not Found"

def binary_search(value, start=0, end=len(Array)):
    global all_time_2, start_time_2
    middle = (start + end) // 2

    if value < Array[start] or value > Array[end - 1]:
        return "Not Found"

    if value == Array[middle]:
        all_time_2 += (time.time() - start_time_2)
        return "" + str(middle) + " " + str(Array[middle])

    if value < Array[middle]:
        return binary_search(value, start, middle)
    else:
        return binary_search(value, middle, end)

for i in range(100):
    lineare_serach(int(number))
    binary_search(int(number))


print("Linear Search: " + str((all_time_1 / 100)))
print("Binary Search: " + str((all_time_2 / 100)))