open System

let vigenere str key =
 let A = (int)'A' // 65 
 let a = (int)'a' // 97
 let strLength = String.length str // length of string
 let keyLength = String.length key // length of keyword

 // Takes a char (c) and makes it upper case, then finds position in the array
 // i.e returns 0, 1, 10, up to 25.
 let encKey (c:char) = 
    let upperChar = Char.ToUpper c
    (int upperChar) - A
 
 // Takes a char (c) if its upper then
 // true...executed which gets the chars ASCII then minus 65 then modulus to get the 
 // position in the alphabet i.e. 0 - 26 then adds A i.e. 65 to make it an ASCII char in the alphabet.
 let encChar c k : char = 
   match Char.IsUpper c with
   | true -> ((int)c + (int)k - A) % 26 + A
   | false -> ((int)c + (int)k - a) % 26 + a
   |> char
 
 // loop i = 0 to whatever strLength - 1 is, in increments of 1.
 // MOTHER OF GOD, NEED TO COUNT SPACES AND BACK TRACK KEYWORD CUMULATIVELY.
 let mutable countSpace = 0 
 for i = 0 to strLength - 1 do 
  let enc = 
   let j = if i = 0 then i % keyLength else (i - countSpace) % keyLength
   // If str.[0] = M is a letter then encrypt.
   if Char.IsLetter str.[i] then (encChar str.[i] (encKey key.[j]))
   // If its not a letter it must be a space so just return the space 
   // i.e. print it as is.
   else 
    countSpace <- countSpace + 1
    str.[i]

//  printfn "keyChar: %c  index: %i  i: %i  strChar: %c  encChar: %c  encKey: %i  j: %i" key.[i % keyLength]  (i % keyLength) i str.[i] enc (key.[i % keyLength] |> int) (i % keyLength)
  printf "%c" enc // print the encrypted char of the string.
 printfn "\n%s" str // print the encrypted char of the string.

vigenere "Meet me at the park at eleven am" "bacon" 

// "Negh zf av huf pcfx bt gzrwep oz"