let sonuc;

sonuc = Number('10.6')

console.log(sonuc, typeof sonuc);

sonuc = parseInt('10.6'); // noktadan sonraki kısmı atar
console.log(sonuc, typeof sonuc);

sonuc = parseInt('10abc')
console.log(sonuc, typeof sonuc);

sonuc = parseInt('10abc34')
console.log(sonuc, typeof sonuc);

sonuc = parseInt('abc2cc')
console.log(sonuc, typeof sonuc);

sonuc = parseFloat('10.6abc')
console.log(sonuc, typeof sonuc);


let sayi = 15.5189814 // yuvarladı string yaptı
sonuc = sayi.toFixed();
sonuc = sayi.toFixed(2);
console.log(sonuc, typeof sonuc);

sonuc = sayi.toPrecision(6); // virgülden öncei ve sonraki karakter toplamına göre hareket eder.
console.log(sonuc, typeof sonuc);

sonuc = Math.round(2.4);
sonuc = Math.round(2.5);
console.log(sonuc, typeof sonuc);

sonuc = Math.ceil(2.2); // tavana yuvarlar
console.log(sonuc, typeof sonuc);

sonuc = Math.floor(2.8); // tabana yuvarlar
console.log(sonuc, typeof sonuc);

sonuc = Math.pow(5,2); // kare alma
console.log(sonuc, typeof sonuc);

sonuc = Math.sqrt(25); // karekök alma
console.log(sonuc, typeof sonuc);

sonuc = Math.abs(-5); // mutlak değer alma
console.log(sonuc, typeof sonuc);

sonuc = Math.min(5,2,3,98,16); // en küçük alma
console.log(sonuc, typeof sonuc);

sonuc = Math.max(5,2,3,98,16); // en büyük alma
console.log(sonuc, typeof sonuc);

sonuc = Math.random(); // rastgele sayı üretir 0-1 arası
console.log(sonuc, typeof sonuc);

sonuc = parseInt(Math.random()*100);
console.log(sonuc, typeof sonuc);







