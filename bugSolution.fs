let x = 10
let y = 20

let add x y = 
    let x' = x + y
    let y' = y + x'
    (x', y') // Return both result in a tuple

let (x', y') = add x y
printf "%d %d" x' y' 