//Add 5 to the front of the list via the cons operator
//Both lines do the same thing
5 :: [1; 2; 3];;
[5] @ [1; 2; 3];;

List.map (fun xs -> 5::xs) [[1; 2]; [3]];; //Adds 5 to the front of each list
List.map (fun xs -> xs + 1) [1; 2; 3; 5];; //Increase each element of the list by 1
List.rev ([] : int list);; //Reverses an empty list without getting an error
List.rev [1; 3; 5];; //Reverses the list

//Product function
//Recursively multiplies the product by the head of the list
let rec prod ns =
    if List.isEmpty ns then 1
    else List.head ns * prod (List.tail ns);;

//Product of the elements of a list of integers from 1 to 5
prod [1..5];;
