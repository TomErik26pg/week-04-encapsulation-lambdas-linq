# Oppgave 04 — Rule Runner

**Hovedfokus:** delegates og Func<T, bool> med named method

Lag en metode som mottar **oppførsel** som parameter:

```csharp
static void PrintMatching(List<int> values, Func<int, bool> condition)
```

Metoden skal skrive bare tall der `condition(value)` returnerer `true`.

Første gang skal du **ikke** bruke lambda. Lag en named method, for eksempel:

```csharp
static bool IsHighReading(int value)
```

og send metoden inn til `PrintMatching`.

Målet er å se at en metode kan behandles som en verdi som sendes til en annen metode.

## Kjøring

```bash
dotnet run
```
