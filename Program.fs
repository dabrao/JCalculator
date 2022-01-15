open JCalculator
open JOperations

let test =
    { Operator = Addition
      FirstOperand = 7.7
      SecondOperand = 2.3 }

printfn "%f" (jCalculator test)

