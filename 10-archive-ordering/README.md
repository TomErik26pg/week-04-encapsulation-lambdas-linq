# Oppgave 10 — Archive Ordering

**Hovedfokus:** OrderBy + chaining

Bygg en LINQ-chain som:
1. beholder artifacts med `Risk >= 30`
2. sorterer dem alfabetisk på `Name`
3. projiserer dem til strings som `"Name: Risk"`

Lagre resultatet og iterer over det.

Lag deretter en ny chain som sorterer alle artifacts på `Risk`.

Diskuter for deg selv hva slags data hvert trinn produserer: `Artifact`-objekter eller strings?

## Kjøring

```bash
dotnet run
```
