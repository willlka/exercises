module Accumulate

let accumulate<'a, 'b> (func: 'a -> 'b) (input: 'a list): 'b list = 
    let result = []
    let rec funcRec (tail: 'a list, i: int): 'b list =  
        match tail with
        | [] -> result
        | _ -> result |> List.append (funcRec (tail.Tail, i+1)) |> List.append [func(tail.Head)]
    funcRec(input, 0)