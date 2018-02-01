//Finding the last element in a list
let rec myLast = function
    | [] -> failwith "This list is empty."
    | [x] -> x
    | _::xs -> myLast xs

myLast [1; 3; 7; 9];;

//Finding the second to last element in a list
let rec myButLast = function
    | [] -> failwith "This list is empty."
    | [x] -> failwith "This is a singleton."
    | [x; _] -> x
    | _::xs -> myButLast xs

myButLast [1; 3; 7; 9];;
