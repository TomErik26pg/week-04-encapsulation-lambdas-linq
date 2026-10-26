# Oppgave 02 — The Leaking Collection

**Hovedfokus:** intern collection vs kopi

`Archive` under starter med en designfeil: `GetEntries()` returnerer den **faktiske interne listen**.

Del A:
1. Kall `GetEntries()`.
2. Gjør `Clear()` på resultatet.
3. Vis at arkivets interne data også forsvinner.

Del B:
Endre `GetEntries()` slik at den returnerer en **ny liste/kopi** av entries.

Kjør det samme eksperimentet igjen. Nå skal strukturelle endringer på den returnerte listen ikke endre arkivets interne liste.

## Kjøring

```bash
dotnet run
```
