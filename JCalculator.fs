namespace JCalculator

type JOperator =
    | Addition
    | Subtraction
    | Multiplication
    | Division
    | Modulo
    | Exponentiation
    | Maximum
    | Minimum
    

type JOperation =
    { Operator : JOperator
      FirstOperand : float
      SecondOperand : float }
