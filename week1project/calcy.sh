#!/bin/bash

echo "Enter the total number of points: "
read total

echo "Enter the student's score: "
read score

percent=$(echo "scale=2; $score / $total * 100" | bc)

if (( $(echo "$percent >= 90" | bc -l) )); then
    grade="A"
elif (( $(echo "$percent >= 80" | bc -l) )); then
    grade="B"
elif (( $(echo "$percent >= 70" | bc -l) )); then
    grade="C"
elif (( $(echo "$percent >= 60" | bc -l) )); then
    grade="D"
else
    grade="F"
fi

echo "The student's percentage score is: $percent%"
echo "The student's grade is: $grade"

