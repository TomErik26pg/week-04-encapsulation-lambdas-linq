# Oppgave 01 — Specimen Vault

**Hovedfokus:** private state og kontrollert modifikasjon

`SpecimenVault` skal **eie** sin mutable state.

Krav:
- Listen skal være et privat felt: `private List<string> specimens`.
- Resten av programmet skal bruke metoder som `Add`, `Remove` og `PrintAll`.
- `Program.cs` skal ikke kunne skrive `vault.specimens.Add(...)`.

Legg inn noen specimen-navn gjennom den offentlige API-en og bekreft at vaulten styrer endringene.

## Kjøring

```bash
dotnet run
```
