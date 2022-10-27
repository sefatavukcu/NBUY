// let obje1 = {
//     "urunAd":"IPhone 12",
//     "urunFiyat": 27000,
//     'urunRenk':'Gri',
//     'onayli':true,
// }

// console.log(obje1);
// console.log(obje1.urunFiyat);
// console.log(obje1.urunAd);
// obje1.urunFiyat=45000;
// console.log(obje1.urunFiyat);

// obje1.urunAdet=15;  // sonradan da tanımlanabilir.
// console.log(obje1);

// let obje2 = {
//     "urunAd":"IPhone 13",
//     "urunFiyat": 29000,
//     'urunRenk':'Mavi',
// }
// obje2.onayli=false;

// if (obje2.onayli==undefined) {
//     console.log('Lütfen admin ile iletişime geçiniz.');
// } else {
//     if (obje2.onayli==true) {
//         console.log('Bu ürün satışta!');
//     } else {
//         console.log('Gelince haber ver!');
//     }
// }

// let ogrenci1 = {
//     'ogrenciNo':144,
//     'ogrenciAd':'Ali',
//     'ogrenciSoyad':'Babahan',
//     'ogrenciYas':19,
//     'ogrenciAktif':true,
// }
// ogrenci1.cinsiyet='Erkek';

// if ('cinsiyet' in ogrenci1) {
//     console.log(ogrenci1.cinsiyet);
// } else {
//     console.log('Böyle bir özellik tanımlı değil!');
// }


// let kisi1 = {
//     'Ad Soyad':'Serhat Cankuş',
//     'Doğum Tarihi':'11.05.1999',
//     kidemYili:27
// };

// console.log(kisi1["Ad Soyad"]); // Arada boşluk bırakınca index gibi algılıyor.
// console.log(kisi1.kidemYili);  // tanımlarken tırnak içine yazmasak da oluyor.


// let product1 = {
//     productId : 12,
//     productName : 'Samsung S21',
//     productPrice : 26000,
// };

// let product2 = {
//     productId : 13,
//     productName : 'IPhone 14',
//     productPrice : 37000,
// };

// let product3 = {
//     productId : 14,
//     productName : 'Xiaomi Mi 12',
//     productPrice : 23000,
// };

// let products = [product1,product2,product3];
// console.log(products);

// let products = [
//     {
//         id:13,
//         name:'Iphone',
//         price:26000
//     },
//     {
//         id:14,
//         name:'Samsung',
//         price:21000
//     },
//     {
//         id:15,
//         name:'Xiaomi',
//         price:19000
//     }
// ];
// console.log(products);
// console.log(products[2].name+ ' '+ products[2].price);

let category1 = {};
category1.name ='Telefon';
let category2 = {};
category2.name ='Bilgisayar';
let categories = [category1,category2];
console.log(categories);
