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

// December 26, 2022
// Medium

// Identify all subarrays of length 3 with 0 and 2 position being same number.

// Notes: I struggled in that I was missing my brackets while passing in the array of args. A simple syntax error which caused
// a bit of frustration because, while the debugger was running, it would skip the entire function body.

const boomerang = function (arr) {
  let count = 0;

  for (let i = 0, j = 3; j <= arr.length; i++, j++) {
    const sub = arr.slice(i, j);
    if (sub[0] === sub[2] && sub[1] !== sub[0]) {
      count += 1;
    }
  }
  return count;
};
boomerang([5, 9, 5, 9, 5]);

// December 26, 2022
// Hard

// Return whether or not the summed digits of a single integer are even or odd.
// NEED TO FIND SOLUTION. THIS DOESN'T PASS TESTS.

const oddishEvenish = function (num) {
  let sum = ((num - 1) % 9) + 2;
  return sum % 2 === 0 ? "Evenish" : "Oddish";
};
oddishEvenish(4433);
