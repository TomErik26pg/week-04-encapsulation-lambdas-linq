# Oppgave 06 — Complex Scanner Rule

**Hovedfokus:** multi-line lambda

Noen regler trenger mer enn ett uttrykk.

Send en **multi-line lambda** til `PrintMatching`.

Regelen skal:
1. beregne `distanceFromCenter = Math.Abs(value - 50)`
2. lagre en bool som sier om avstanden er maks 10
3. returnere bool-verdien

Dermed godtas verdier fra 40 til 60.

Bruk `{ ... }`-kropp og eksplisitt `return` i lambdaen.

## Kjøring

```bash
dotnet run
```
