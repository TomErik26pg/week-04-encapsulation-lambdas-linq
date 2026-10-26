# Oppgave 03 — The Shallow Copy Surprise

**Hovedfokus:** referansetyper inne i collections

Nå brukes objekter i stedet for strings.

`GetDrones()` skal returnere en **ny List<Drone>**, slik at `Add`/`Remove` på kopien ikke endrer den interne listen.

Deretter skal du observere noe viktig:

```csharp
copy[0].Name = "CHANGED";
```

Selv om listen er kopiert, peker begge lister fortsatt på de **samme Drone-objektene**.

Oppgaven:
1. Vis at `copy.RemoveAt(0)` ikke endrer vaultens antall når listen returneres som kopi.
2. Vis at endring av `copy[0].Name` likevel endrer objektet vaulten ser.
3. Skriv 2–4 setninger i `NOTES.md` om hvorfor.

Dette er en bevisst introduksjon til shallow copy og referansetyper, ikke et krav om å implementere deep clone.

## Kjøring

```bash
dotnet run
```
