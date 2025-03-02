def the_best_function_ever(*args, **kwargs) -> int:
    print(kwargs.get("b"), kwargs.get("c"))
    return 10


def doSmth(func):
    func(1)


def smth(i=10):
    print(i)


def a():
    return (1, 2)


if __name__ == "__main__":
    with open("a.txt", "wb") as file:
        file.write("Hello binary string".encode("UTF-16"))

    with open("a.txt", "rb+") as file:
        decode = file.read().decode("UTF-16")
        print(decode)