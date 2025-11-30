print("Zadanie drugie")
_input = input("Wybierz kierunek konwersji. C (Celsjusz -> Fahrenheit) lub F (Fahrenheit -> Celsjusz)")
if _input == "C":
    _temp = float(input("Podaj Temperature do konwersji: "))
    result = (_temp * 9 / 5) + 32
    print("Temperatura w Celsjusza {} w Fahrenheitach to {}".format(_temp,result))
elif _input == "F":
    _temp = float(input("Podaj Temperature do konwersji: "))
    result = (_temp - 32) * 5 / 9
    print("Temperatura w Fahrenheita {} w Celsjuszach to {}".format(_temp,result))
else:
    raise RuntimeError("Niepoprawna operacja")