module CollatzConjecture
let rec stepsOfCollatz(currentStep: int, number: int): int option = 
    match number with
    | x when x <= 0 -> None
    | 1 -> Some(currentStep)
    | x when x % 2 = 0 -> stepsOfCollatz(currentStep + 1, number / 2)
    | x when x % 2 <> 0 -> stepsOfCollatz(currentStep + 1, number * 3 + 1)
    | _ -> None

let steps (number: int): int option = 
    stepsOfCollatz(0, number)