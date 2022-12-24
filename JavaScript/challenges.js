"use strict";

// December 2, 2022
// Easy

// You will be given an array of drinks, with each drink being an object with two properties: name and price.
// Create a function that has the drinks array as an argument and return the drinks objects sorted by price
// in ascending order.

const drinks = [
  { name: "lemonade", price: 50 },
  { name: "lime", price: 10 },
];

const sortDrinkByPrice = drinks.sort((a, b) => a.price - b.price);

console.log("");

// December 2, 2022
// Medium

// Return the amount of true values in an array of booleans.

const findTrues = (arr) =>
  function trues(arr) {
    let counter = 0;
    arr.forEach((t) => {
      if (t === true) counter++;
    });
    return counter;
  };

findTrues([true, false, false, false, true]);

// December 22, 2022
// Hard

// Return true if array contains the digit 7, false otherwise.

const containsSeven = (arr) =>
  arr.join("").includes(7)
    ? "Boom!"
    : "None of the items contain 7 within them.";
containsSeven([1, 2, 3, 4, 5, 6, 1070]);

// December 24, 2022
// Easy

// Create a function that takes an array of non-negative ints and strings and returns a new array without the strings.

const noStrings = function (arr) {
  const stringless = arr.filter((x) => typeof x != "string");
  return stringless;
};

noStrings([1, 2, "a", "b"]);
