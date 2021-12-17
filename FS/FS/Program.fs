
module Bin2Dec =

    let convert str =
        
        let array = [| for c in str do
                                yield string c |]

        let convert2 (col: 'string[]) =
            [| for n = col.Length - 1 downto 0 do
                    yield (int array[n] * pown 2 (array.Length - n - 1)) |]

        Array.sum (convert2 array)

[<EntryPoint>]
let main argv =

    let result = Bin2Dec.convert "100101"
    printfn "%i" result

    0
