module TwoFer

let name (input: string option): string = 
    "One for " + (if input.IsNone || Option.toObj(input) = "" then "you" else Option.toObj(input)) + ", one for me."