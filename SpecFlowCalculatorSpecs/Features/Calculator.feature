Feature: I want to be able to add numbers in the string calculator code kata

  Scenario: the one with an empty string
    Given an empty string
    When the string is calculated
    Then the result is 0

 Scenario: the one with two comma separated numbers in a string
    Given a string "1,2"
    When the string is calculated
    Then the result is 3

  Scenario: the one with three comma separated numbers in a string
    Given a string "1,2,5"
    When the string is calculated
    Then the result is 8

  #Scenario: The one with an illegal number
    #Given a string "1,2,-3"
    #Then the calculation of the string throws a NegativeNumberNotAllowed exception

 # Scenario Outline: the ones to verify that number over 1000 are not included in the sum
   #  Given a string "<numbers>"
    # When the string is calculated
     #Then the result is <result>

     #Examples:
      # |numbers | result |
       #|1,999   | 1000   |
       #|1,1000  | 1001   |
       #|1,1001  | 1      |

   #Scenario: the one with a different separator
     #Given a string "|1|2|3"
     #When the string is calculated
     #Then the result is 6


  # Scenario Outline: the one with many numbers
    # Given a string "<numbers>"
    # When the string is calculated
    # Then the result is <result>

    # Examples:
   #  |numbers | result |
   #  |   1,5  |   6    |
   #  | 1,5,6  |  12    |
   #  | 7,7,7  |  21    |
    # | 7,8,7  |  22    |
   # | 7,9,7  |  23    |
    # | 7,10,7 |  24    |
    # | 7,11,7 |  25    |
    # | 7,12,7 |  26    |
    # | 7,13,7 |  27    |
