#!/bin/bash
echo "This project is to showcase what i have learned."

echo "Enter a car brand that you'd like to determine reliability for:"
read brand

### Conditioal statemennts to determie the brand ##
if [[ "$brand" == "Toyota" ]]; then
  reliability=9.0
elif [[ "$brand" == "Honda" ]]; then
  reliability=10.0
elif [[ "$brand" == "Ford" ]]; then
  reliability=7.5
elif [[ "$brand" == "Chevrolet" ]]; then
  reliability=7.0
elif [[ "$brand" == "Audi" ]]; then
  reliability=5.0
elif [[ "$brand" == "BMW" ]]; then
  reliability=4.5
elif [[ "$brand" == "Mercedes" ]]; then
  reliability=6.0
elif [[ "$brand" == "Kia" ]]; then
  reliability=8.0
elif [[ "$brand" == "Dodge" ]]; then
  reliability=7.0
elif [[ "$brand" == "Acura" ]]; then
  reliability=8.5
elif [[ "$brand" == "Buick" ]]; then
  reliability= 7
elif [[ "$brand" == "Infiniti" ]]; then
  reliability=8
elif [[ "$brand" == "Jeep" ]]; then
  reliability=7.5
elif [[ "$brand" == "Lexus" ]]; then
  reliability=7.0
elif [[ "$brand" == "Mazda" ]]; then
  reliability=8.5
elif [[ "$brand" == "Nissan" ]]; then
  reliability=9
elif [[ "$brand" == "Potiac" ]]; then
  reliability=6.5
elif [[ "$brand" == "Ram" ]]; then
  reliability=8
elif [[ "$brand" == "Scion" ]]; then
  reliability=8.0
elif [[ "$brand" == "Subaru" ]]; then
  reliability=9.0
elif [[ "$brand" == "Tesla" ]]; then
  reliability=9.0
elif [[ "$brand" == "Volkswagen" ]]; then
  reliability=9.5
elif [[ "$brand" == "Mitsubishi" ]]; then
  reliability=8.5
elif [[ "$brand" == "Jaguar" ]]; then
  reliability=7.0
elif [[ "$brand" == "Hyundai" ]]; then
  reliability=8.5
elif [[ "$brand" == "Genesis" ]]; then
  reliability=7.5
elif [[ "$brand" == "Chrysler" ]]; then
  reliability=8.0
elif [[ "$brand" == "GMC" ]]; then
  reliability=8.5
## A Brad is entered that isnt on file. ##
else
  reliability=6.0
fi

echo "The reliability of $brand is $reliability out of 10.0"
