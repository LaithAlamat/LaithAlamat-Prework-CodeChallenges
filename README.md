# LaithAlamat-Prework-CodeChallenges

# Prework-CodeChallenges

## Array Max Result : 
You can select any number from the list,
however your scoring will be depend on the frequency of that number in the list. 
E.g for [2,2,3,5,4] if you pick 2 your score will be 4 (2 2) but if you pick 5 your score will be 5 (5 1).

***Instructions:***
- We create two methods (one to find the answer and the other to print the array)
- We declare an integer named count and assign the value zero to it.
- Then we ask the user to select the value from the array.
- Then we loop over the array to find how many counts for the sellected value.
- We multiply the number we sellected with the count and return its value.



## LeapYearCalculator :

Given a year, report if it is a leap year.
- on every year that is evenly divisible by 4
- except every year that is evenly divisible by 100
- unless the year is also evenly divisible by 400

***Instructions:***
- We ask the user to inter a year.
- We take that value and compare it withsome rules to make sure if it applies to a leap year.


## perfectSequence : 

Given an array, return �Yes� if the sequence is considered a perfect sequence. Otherwise, return �No�
A perfect sequence is a sequence such that all of its elements are non-negative integers and the product of all of them is equal to their sum.
For example: [2,2], [1,3,2] and [0,0,0,0] are perfect sequences and [4,5,6] and [0,2,-2] are not perfect sequences.

***Instructions:***
- We loop over the sellected array.
- we make sure that each index is a positive value.
- Then we sum the values in the array and we mulitply them also.
- If all of the values are positive in the array and the multiplication equals the summation then we return yes, if not we return no.

## SumOfRows
Given a matrix of integers. Return the sum of each row in a single dimensional array.

***Instructions:***
- We loop over the multidimentional array.
- We loop over the inner array.
- We add the values in the inner array and store it in another array.
- Each summation of a row will be a separate index in the output array.
