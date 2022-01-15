namespace JCalculator

type JOperator =
    | Addition
    | Subtraction
    | Multiplication
    | Division
    | Modulo
    | Exponentiation

type JOperation =
    { Operator : JOperator
      FirstOperand : float
      SecondOperand : float }
