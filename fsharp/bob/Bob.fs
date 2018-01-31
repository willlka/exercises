module Bob

let response (input: string): string = 
    let trimmed = input.Trim(['\u0000' .. ' '] |> List.toArray)
    let withoutUpper = 
        [
            for i in 0 .. trimmed.Length - 1 do
                if trimmed.[i] < 'A' || trimmed.[i] > 'Z' then
                    yield trimmed.[i]
        ]
    match trimmed with
        | x when x.Length = 0 -> "Fine. Be that way!"
        | x when trimmed = trimmed.ToUpper() && trimmed.Length <> withoutUpper.Length -> "Whoa, chill out!"
        | x when trimmed.[trimmed.Length-1] = '?' -> "Sure."
        | _-> "Whatever."