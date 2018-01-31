module ArmstrongNumbers

let rec parseNumber(number: int, parsed: int list): int list = 
    match number with
    | x when x < 0 -> []
    | 0 -> parsed
    | _ -> parseNumber(number / 10, parsed |> List.append [number % 10])
    
let powAll(parsed: int list): int =
    parsed |> List.map(fun x -> Operators.pown x parsed.Length) |> List.sum

let isArmstrongNumber (number: int): bool = 
    let parsed: int list  = parseNumber(number, [])
    match parsed with
    | [] | _ -> false
    | x when powAll(x) = number -> true
