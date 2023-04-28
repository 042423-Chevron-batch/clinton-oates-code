#!/bin/bash
echo "This project is to showcase what i have learned."

echo "Enter a car brand that you'd like to determine reliability for:"
read brand

if [[ "$brand" == "Toyota" ]]; then
  reliability=9.0
elif [[ "$brand" == "Honda" ]]; then
  reliability=9.0
elif [[ "$brand" == "Ford" ]]; then
  reliability=7.5
elif [[ "$brand" == "Chevrolet" ]]; then
  reliability=7.0
else
  reliability=6.0
fi
