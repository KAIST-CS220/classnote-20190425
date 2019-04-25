let mutable cnt = 0 // global variable

let counter () =
  cnt <- cnt + 1 //  ()
  cnt

let counter2 () =
  cnt <- cnt + 1 //  ()
  cnt

let makeCounter () =
  let mutable cnt = 0
  fun () -> cnt <- cnt + 1; cnt

let f x =
  x |> List.iter (printfn "before: %d")
  1 :: x
  |> fun x ->
       List.iter (printfn "after: %d") x; x

// [1] // FSHARP list // immutable list
// System.Collections.Generic.List// mutable list

// while cond do body
//
// let rec w () =
//   if cond then
//     body
//     w ()
//   else ()

[<EntryPoint>]
let main argv =
  f [1;2;3] |> ignore // No-op
  0 // return an integer exit code
