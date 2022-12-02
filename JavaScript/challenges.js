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

trues([true, false, false, false, true]);
