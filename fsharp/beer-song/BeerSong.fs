module BeerSong

let recite (startBottles: int) (takeDown: int) =
    let result: string list = []
    let rec funcRec(currentIter: int, result: string list): string list = 
        match currentIter with
        | x when x = takeDown || startBottles - x < 0 -> result
        | x when startBottles - x = 0 -> funcRec(currentIter + 1, ["No more bottles of beer on the wall, no more bottles of beer."; "Go to the store and buy some more, 99 bottles of beer on the wall."] |> List.append result)
        | x when startBottles - x = 1 -> funcRec(currentIter + 1, ["1 bottle of beer on the wall, 1 bottle of beer."; "Take it down and pass it around, no more bottles of beer on the wall."] |> List.append result)
        | x when startBottles - x = 2 -> funcRec(currentIter + 1, ["2 bottles of beer on the wall, 2 bottles of beer."; "Take one down and pass it around, 1 bottle of beer on the wall."] |> List.append result)
        | x when startBottles - x > 2 -> funcRec(currentIter + 1, [(startBottles - x).ToString() + " bottles of beer on the wall, " + (startBottles - x).ToString() + " bottles of beer."; "Take one down and pass it around, " + (startBottles - x- 1).ToString() + " bottles of beer on the wall."] |> List.append result)
        | _ -> []
    
    funcRec(0, result)
