const numeros = [1, 4, 7, 9, 13];

let soma = 0;

for (let i = 0; i < numeros.length; i++){
    soma += numeros[i];
}

const media = soma/numeros.length;
console.log("A média é: " + media);
