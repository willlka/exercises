module GradeSchool

let empty: Map<int, string list> = Map.empty

let add (student: string, grade: int, school: Map<int, string list>): Map<int, string list> =   
    let s: string list = [student]
    if school.ContainsKey(grade) then             
        school.Add(grade, s |> List.append(school.Item(grade)) |> List.sort)
    else school.Add(grade, [student])

let roster (school: Map<int, string list>) =
    school

let grade (number: int) (school: Map<int, string list>): string list = 
    if school.ContainsKey(number) then 
        school.Item(number) |> List.sort
    else []