open JCalculator
open JOperations

let test =
    { Operator = Minimum
      FirstOperand = 7.7
      SecondOperand = 2.3 }

printfn "%f" (jCalculator test)

