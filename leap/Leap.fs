module Leap

let leapYear (year: int): bool = 
    let divisibleByFour = year%4 = 0
    let divisibleByOneHundred = year%100 = 0
    let divisibleByFourHundred = year%400 = 0

    divisibleByFour && (not divisibleByOneHundred || divisibleByFourHundred);
