# Oppgave 11 — Reusable Search Engine

**Hovedfokus:** delegate/lambda som innsendt atferd

`ArtifactArchive` skal eie en privat liste og tilby:

```csharp
public List<Artifact> FindArtifacts(Func<Artifact, bool> condition)
```

Metoden skal bruke den innsendte conditionen til å velge hvilke objekter som returneres.

Kall metoden med flere lambdas:
- høy risiko
- bestemt origin
- navn som inneholder en tekstbit

Dette binder sammen innkapsling, delegates og lambdas. Du kan bruke `Where(...).ToList()` inne i metoden.

## Kjøring

```bash
dotnet run
```
