# Notater

- TODO: Hva skjer med selve listen?
- TODO: Hva skjer med objektene i listen?


//3. Skriv 2–4 setninger i `NOTES.md` om hvorfor.
GetDrones() opretter en ny liste som inneholder referanser til samme drone-objekter som original listen, ved bruk av RemoveAt(0) endrer vi bare den kopierte 'copy' listen mens DroneVault forblir uendret.

Ved bruk av copy[0].Name = "CHANGED" endrer vi objektet direkte da selv om listen er en ny kopi inneholder den en direkte referanse til drone-objektet.