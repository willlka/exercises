module Accumulate

//not my solution, but it's perfect, I submit it just because I don't want to forget it
let rec accumulate<'a, 'b> (func: 'a -> 'b) (input: 'a list): 'b list = 
    match input with
    | [] -> []
    | h::t -> func(h) :: (accumulate func t)
    