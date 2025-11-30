print("Zadanie pierwsze")
_a = float(input("Podaj liczbe a: "))
_b = float(input("Podaj liczbe b: "))
_input = input("Wybierz opcje (+ - / *): ")
if _input == "+":
    print("Suma: ", _a + _b)
elif _input == "-":
    print("Roznica: ", _a - _b)
elif _input == "*":
    print("Iloczyn: ", _a * _b)
elif _input == "/":
    if(_b == 0):
        raise ArithmeticError("Niewolno dzielic przez zero")
    print("Iloraz: ", _a / _b)
else:
    raise RuntimeError("Niezdefiniowana operacja!")