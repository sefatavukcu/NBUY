let ders = 'Bahçeşehir Üniversitesi Wissen Akademie Iğdır'
// let sonuc;

// // Küçük Harf
// sonuc = ders.toLowerCase();
// sonuc = ders.toLocaleLowerCase(); 
// console.log(sonuc);
// // Büyük Harf
// sonuc = ders.toUpperCase();
// sonuc = ders.toLocaleUpperCase(); 
// console.log(sonuc);

// sonuc = ders.length;
// console.log(sonuc);

// sonuc = ders[0];
// console.log(sonuc);
// sonuc = ders[9];
// console.log(sonuc);
// sonuc = ders[39];
// console.log(sonuc);
// // Kesme
// sonuc = ders.slice(0,10);
// console.log(sonuc);
// sonuc = ders.slice(20,5); // başlangıçtan yaz böyle olmazzzz.
// console.log(sonuc);
// sonuc = ders.slice(10); // sona kadar alır
// console.log(sonuc);

// sonuc = ders.substring(0,10);
// console.log(sonuc);
// // Yazılan rakamların arasını alıyor. En küçüğü referans alır. oradan başlar
// sonuc = ders.substring(10,0);
// console.log(sonuc);
// sonuc = ders.substring(20,25);
// console.log(sonuc);
// sonuc = ders.substring(25,20);
// console.log(sonuc);

// sonuc = ders.replace('Iğdır','İstanbul');
// console.log(sonuc);
// sonuc = ders.replace(' ','-');
// console.log(sonuc);

// sonuc = ders.trim(); // Boşlukları kaldırır.
// sonuc = ders.trimStart();
// sonuc = ders.trimEnd();
// console.log(sonuc);

// sonuc = ders.indexOf('i'); 
// console.log(sonuc);

// sonuc = ders.toLocaleLowerCase().indexOf('a'); 
// console.log(sonuc);

// sonuc = ders.split(' ');
// console.log(sonuc);
// console.log(sonuc[3]);


// Kullanıcının girdiği bir cümlenin kaç sözcükten oluştuğunu bulunuz.

// let metin = prompt('Metin Giriniz.')
// let sozcuk = metin.split(' ');
// console.log(sozcuk.length);

sonuc = ders.includes('a');
console.log(sonuc);
sonuc = ders.includes('Akademie');
console.log(sonuc);

sonuc = ders.startsWith('B');
console.log(sonuc);
sonuc = ders.endsWith('k');
console.log(sonuc);
sonuc = ders.endsWith('Iğdır');
console.log(sonuc);