#r "nuget: CliWrap"

open CliWrap
open System
open System.Threading.Tasks

// switch this one in case you're not in windows
let command =
    // "dotnet"
    "dotnet.exe"


task {
    let result =
        Cli
            .Wrap(command)
            .WithArguments(
                [ "fable"
                  "watch"
                  "./src/fable37-cli.fsproj" ]
            )
            .WithStandardOutputPipe(PipeTarget.ToStream(Console.OpenStandardOutput()))
            .WithStandardErrorPipe(PipeTarget.ToStream(Console.OpenStandardError()))
            .ExecuteAsync()

    do! result.Task :> Task
}
|> Async.AwaitTask
|> Async.RunSynchronously
