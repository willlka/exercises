module SumOfMultiples

let sumOfMultiples (numbers: int list) (upperBound: int): int =
    let rec checkMultiplier (n: int, l: int list) : int =
        match l |> List.filter(fun y -> n % y = 0) with
            | [] -> 0
            | _ -> n
    
    List.sum([1..upperBound-1] |> List.map(fun x -> checkMultiplier(x, numbers)))    