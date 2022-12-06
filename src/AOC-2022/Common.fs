module AOC_2022
    open System.IO

    // Return array of strings the binary input.
    let getData (filename) =
        File.ReadLines(filename)