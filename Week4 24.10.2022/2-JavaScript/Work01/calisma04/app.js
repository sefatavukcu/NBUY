/* 

4) Girilen bir yıl değerinin (örneğin: 1975) artık yıl olup olmadığını bulup konsola sonucu 
yazdırın. Bir yıl 400'e tam olarak bölünebiliyorsa ya da 4'e tam olarak bölünmekle 
birlikte 100'e de tam olarak bölünebiliyorsa artık yıldır.

*/

let yil = Number(prompt('Bir yıl değeri Giriniz.'));

if (yil % 4==0 && yil % 100 ==0) {
    console.log('Artık yıl');
}
else{
    console.log('Artık yıl değildir.');
}