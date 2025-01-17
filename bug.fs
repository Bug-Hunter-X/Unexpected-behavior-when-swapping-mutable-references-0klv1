let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //Prints 20 20 as expected

let mutable a = [1;2;3]
let mutable b = [4;5;6]

let swapList a b = 
    let temp = a
    a <- b
    b <- temp

swapList a b
printf "%A %A" a b //Prints [4;5;6;] [1;2;3] as expected 

let mutable c = {Name = "Alice"; Age = 30}
let mutable d = {Name = "Bob"; Age = 25}

let swapRecords c d = 
    let temp = c
    c <- d
    d <- temp

swapRecords c d
printf "%A %A" c d //Prints {Name = "Bob"; Age = 25} {Name = "Alice"; Age = 30} as expected

//However, consider the following:

let mutable e = 10
let mutable f = 20

let swapValues e f = 
    let temp = e
    e <- f
    f <- temp

let g = ref e
let h = ref f

swapValues !g !h
printf "%d %d" !g !h //Prints 20 20 as expected

let mutable i = [1;2;3]
let mutable j = [4;5;6]

let swapListValues i j = 
    let temp = i
    i <- j
    j <- temp

let k = ref i
let l = ref j

swapListValues !k !l
printf "%A %A" !k !l //Prints [4;5;6] [1;2;3] as expected

//This is all fine and dandy, but what happens when we try to swap mutable references? 

let mutable m = ref 10
let mutable n = ref 20

let swapRef m n = 
    let temp = m
    m <- n
    n <- temp

swapRef m n
printf "%d %d" !m !n //Prints 20 10 as expected 

let mutable o = ref [1;2;3]
let mutable p = ref [4;5;6]

let swapListRef o p = 
    let temp = o
    o <- p
    p <- temp

swapListRef o p
printf "%A %A" !o !p //Prints [4;5;6] [1;2;3] as expected

//This seems correct, but it's not! The references themselves have been swapped, but not the underlying values. 
//The correct behavior would be to swap the values contained within the references.
