namespace Haku

open System

module text =
    let private rand = Random()

    let dialog (text: string, time: int, newline: bool, randomized: bool) =
        let mutable step: int = 0
        let mutable txt: string = ""
        let mutable t = time

        if newline then txt <- text + "\n"
        else txt <- text + " "
        (while step < text.Length do
            printf "%c" txt.[step]
            step <- step + 1
            if randomized then t <- t + rand.Next(0, 50)
            System.Threading.Thread.Sleep(t)
            if randomized then t <- time
        )
        
    let clear () = System.Console.Clear()