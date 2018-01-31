module Raindrops

let convert (number: int): string = 
    let factors = 
        [3, "Pling"; 5, "Plang"; 7, "Plong"]
        |> List.filter(fun(x, _) -> number % x = 0) 
        |> List.map(fun (_, s) -> s)

    match factors with
    | [] -> number.ToString();
    | s -> String.concat "" s