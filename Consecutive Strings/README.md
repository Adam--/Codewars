# Consecutive strings
_6 kyu_

from https://www.codewars.com/kata/56a5d994ac971f1ac500003e

You are given an array `strarr` of strings and an integer `k`. Your task is to return the first longest string consisting of k consecutive strings taken in the array.

## Description

### Example:

longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"

n being the length of the string array, if `n = 0` or `k > n` or `k <= 0` return "".

### Note

consecutive strings : follow one after another without an interruption
