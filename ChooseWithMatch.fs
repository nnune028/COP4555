//This is the program you did in the functions video, but with match statements instead of if statements.

let add2 n = n + 2;;
let add3 n = n + 3;;

let act (f, v) = f v;;

let choose n =
    match n with
    | n when n > 10 -> add2
    | n -> add3;;

act (choose 7, 7);;
act (choose 17, 17);;
