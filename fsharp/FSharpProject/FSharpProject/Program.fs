// Дополнительные сведения о F# см. на http://fsharp.org
// Дополнительную справку см. в проекте "Учебник по F#".
open System
open Exercises

[<EntryPoint>]
let main (args: string[]) = 
    if args.Length <> 2 then
        failwith "Error";
    let greeting, thing = args.[0], args.[1]
    let timeOfDay = DateTime.Now.ToString("hh:mm tt");

    HelloWorld()

    printfn "%s, %s at %s" greeting thing timeOfDay
    0 // возвращение целочисленного кода выхода
