print("Zadanie trzecie - kalkulator ocen")
_numberOfDegrees = int(input("Podaj liczbe ocen: "))
suma = 0
for i in range(0,_numberOfDegrees):
    try:
        _a = int(input("Podaj Ocene: "))
        if _a < 1 or _a > 6:
            raise ArithmeticError("Ocena spoza zakresu dozwolonego zakresu (1-6)")
        else:
            suma += _a
    except Exception as e:
        print("Blad: ",e)
        break
print("Srednia z {} ocen wynosi: {}".format(_numberOfDegrees,round(suma /_numberOfDegrees,2)))
if (suma / _numberOfDegrees) < 3.0 :
    print("Uczen nie zdal")
else:
    print("Uczen zdal!")

