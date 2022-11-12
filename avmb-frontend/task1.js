function numerosImpares(n) {
  const impares = [];
  for (let num of n) {
    if (num % 2 === 1) {
      impares.push(num);
    }
  }
  return impares;
}

console.log(numerosImpares([1, 2, 4, 5, 53]));
