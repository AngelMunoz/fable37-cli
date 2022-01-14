# Fable CLI Invoke Repro

## Steps

- `dotnet fsi repro.fsx`

it should show something along these lines

```
Fable: F# to JS compiler 3.7.0-beta-009
Thanks to the contributor! @fbehrens

Parsing src\fable37-cli.fsproj...
src> cmd /C dotnet restore fable37-cli.fsproj
  Determining projects to restore...
  All projects are up-to-date for restore.
Project and references (1 source files) parsed in 2125ms

Started Fable compilation...
```

and it will get stale, sometimes files do get compiled but the CLI keeps stale

If you invoke it manually

- `dotnet fable clean --yes`
- `dotnet fable watch ./src/fable37-cli.fsproj`

it will finish the compilation and show something like

```
Started Fable compilation...
Fable compilation finished in 1009ms

Watching...
```

## Extras

Using Fable 3.6.3 does not have this issue
