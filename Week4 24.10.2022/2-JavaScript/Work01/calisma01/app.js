/*
    1) Prompt aracılığı ile kullanıcıdan bir saniye değeri alın. Örneğin 1500. 
    Ardından bu girilen değerin kaç dakika, kaç saniye olduğunu hesaplayıp konsola 
    düzgün bir şekilde yazdırın.
    Örnek sonuç: 
    Girilen değer: 1270
    Sonuç: 21 dakika 10 saniye

*/

let deger = Number(prompt('Bir saniye değeri giriniz.'));
let dakika;

dakika = Math.floor(deger/60);
let saniye = deger % 60;

console.log(dakika + ' dakika ' +  saniye + ' saniye');