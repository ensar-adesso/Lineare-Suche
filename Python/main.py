Array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

number = input("Enter a number: ")

if number == "":
    print("You didn't enter a number")
    pass

if int(number) not in Array:
    print("Number is not in the array")
    pass


def serachArray(value):
    for i in range(len(Array)):
        if Array[i] == value:
            return i
    return "Not Found"

print(serachArray(int(number)))