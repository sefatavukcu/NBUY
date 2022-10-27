// function selamVer () {
//     console.log('Hello JavaScript');
// }
// selamVer();

// function selamVer(isim='') {
//     console.log('Merhaba ' + isim);
// }
// selamVer('Engin');
// selamVer('Hüseyin');
// selamVer();

// function yasHesapla(dogumYili) {
//     return new Date().getFullYear() - dogumYili;

// }

// console.log(yasHesapla(1975));
// let yas = yasHesapla(1990);
// if (yas<30) {
//     console.log('Yaşınız uygun değil');
// } else {
//     console.log('İçeri girebilirsiniz.');
// }


// Bir tutar bilgisi alıp bu tutarın kdv sini hesaplayıp geri döndüren function

// function kdvHesapla(tutar) {
//     let sonuc = (tutar * 0.18).toFixed(2);
//     return sonuc;
// }

// console.log(kdvHesapla(25000));

// function kdvHesapla() {
//     for (let i = 0; i < arguments.length; i++) {
//         console.log(arguments[i]);
        
//     }
// }

// kdvHesapla(100,500,900);

// Kendisine gönderilecek tutar bilgilerini kullanarak kdvleri hesaplayıp 
// geriye hesaplanmış kdvleri içinde barındıran bir dizi döndüren function

// function kdvHesapla() {
//     let sonuc = [];
//     let kdv = 0;
//     for (let i = 0; i < arguments.length; i++) {
//         kdv = arguments[i] * 0.18;
//         kdv = kdv.toFixed(2);
//         sonuc.push(kdv);
//         //sonuc[i]=kdv;
//     }
//     return sonuc;
// }

// console.log(kdvHesapla(100,500,1500,900));


