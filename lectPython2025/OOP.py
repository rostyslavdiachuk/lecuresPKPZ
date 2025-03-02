class Person:
    def __init__(self, name, age):
        self._name = name
        self._age = age
        super().__init__()

    def print_info(self):
        pass


class Student(Person):
    def __init__(self, id=0, name="name", age=10):
        super().__init__(name, age)
        self.__id = id


    def print_info(self):
        super().print_info()
        print(self.__id, self._name, self._age)


if __name__ == '__main__':
    student = Student("123", "234", "345")
    student.print_info()
