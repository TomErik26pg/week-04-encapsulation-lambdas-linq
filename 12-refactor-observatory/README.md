# Oppgave 12 — Refactor the Observatory

**Hovedfokus:** lagdelt struktur / MVC-intro

Programmet fungerer, men `Program.cs` gjør alt: oppretter data, viser meny, filtrerer og formaterer resultater.

Refaktorer til tydeligere ansvar. En mulig struktur er:

```text
Program / ConsoleUI
        ↓
ArtifactService
        ↓
Artifact
```

Krav:
- `Artifact` representerer data.
- En service-/controller-lignende klasse inneholder operasjoner og queries mot collectionen.
- Console-koden håndterer input/output og kaller servicen.
- Ikke legg `Console.ReadLine()` inn i `Artifact`.
- Observerbar funksjonalitet skal fortsatt være: vis alle, vis høy risiko, søk på origin, avslutt.

Dette er en introduksjon til lagdeling og ansvarsseparasjon. Det er **ikke** et krav om å bygge et fullverdig MVC-framework.

## Kjøring

```bash
dotnet run
```
