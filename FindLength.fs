//Finding the length of a list using tail recursion
let findLength xs =
    let rec length acc = function
        | [] -> acc
        | _::xs -> length (acc + 1) xs
    length 0 xs

findLength [1; 3; 2; 5; 9; 21];;
