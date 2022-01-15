module JCalculator.JOperations

    let jCalculator (jOperation : JOperation) : float =
        match jOperation.Operator with
        | Addition ->
          jOperation.FirstOperand + jOperation.SecondOperand
        | Subtraction ->
          jOperation.FirstOperand - jOperation.SecondOperand
        | Multiplication ->
          jOperation.FirstOperand * jOperation.SecondOperand
        | Division ->
          jOperation.FirstOperand / jOperation.SecondOperand
        | Modulo ->
          jOperation.FirstOperand % jOperation.SecondOperand
        | Exponentiation ->
          jOperation.FirstOperand ** jOperation.SecondOperand