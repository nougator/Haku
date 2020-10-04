namespace Haku

open System

module input =
    let mutable private prompt = ""

    let setPrompt(inputPrompt: string) = prompt <- inputPrompt
    let getPrompt () = prompt
    
    let get () =
        printf "%s" prompt
        Console.ReadLine()
