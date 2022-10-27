// while

// let i=0;
// while (i<10) {
//     i++;
//     console.log(i+ '. JavaScript');
// }

// do-while

// let i = 0;
// do {
//     i++;
//     console.log(i + '. js');
// } while (i<10);

// For 


// for (let i = 1; i <= 10; i++) {
//     console.log(i + '. JavaScript');
    
// }

// 1-10 arasındaki sayıları toplayıp yazdır
// for
// let toplam=0;
// for (let i = 1; i <= 10; i++) {
//     toplam +=i;    
// }
// console.log(toplam);

// // while
// let toplam2 = 0;
// let i=1;

// while (i<=10) {
//     toplam2+=i;
//     i++;
// }
// console.log(toplam2);

// Kullanıcının gireceği 3 sayıyı toplatan kodları for ile yazınız.

// toplam = 0;
// for (let i = 0; i < 3; i++) {
//     let a = prompt(i +1 + '. Sayıyı giriniz:');
//     a = Number(a);
//     toplam+=a;
// };
// console.log(toplam);

// Kullanıcı 0 girene kadar girilen sayıları toplayıp sonucu konsola yazdıran kod

// toplam = 0;
// i=1;
// let a;

// do {
//     a= Number(prompt(i + '. Sayıyı giriniz:'));
//     toplam+=a;
//     i++;
// } while (a!=0);
// console.log(toplam);

// toplam= 0;
// i=1;
// let a;

// while (a!=0) {
//     a = Number(prompt('Gir'));

//         if (a==0) {
//             break;
//         } else {
//             toplam+=a;
//         }
// }
// console.log(toplam);

// toplam= 0;
// i=1;
// let a;

// for (let i = 0; i < 9999999; i++) {
//     a = Number(prompt('Gir'));
//     if (a==0) {
//         break
//     }else {toplam+=a;}
// }
// console.log(toplam);

// son örnekteki girilen sayıları da sonuçta yazdıralım.

// toplam = 0;
// i=0;
// let a = [];

// do {
//     a[i]= Number(prompt(i + 1 + '. Sayıyı giriniz:'));
//     toplam+=a[i];
//     i++;
// } while (a[i-1]!=0);
//// a.pop();
// for (let i = 0; i < a.length - 1; i++) {
//     console.log(i+'. Sayı: ' + a[i]);
    
// }
// console.log('Toplam: '+toplam);

// Kullanıcının istediği kadar sayı girmesini sağlayın.
// Sayı girişi bitişi için 0 a basılması gereksin.
// 0 a basılıp sayı girişi bittiğinde kullanıcıya şu soruyu sorun? Tek mi Çift mi
// Kullanıcı tek derse : tek sayıları ve toplamları
// Çift derse : çift sayıları  ve toplamları

let sayilar=[];
let toplam = 0;
let i = 0;

do {
    sayilar[i]=Number(prompt(i+1 +'. Sayı: '))
    i++;
} while (sayilar[i-1]!=0);
sayilar.pop();
let sonucDizi = [];
let cevap = prompt('Tek mi Çift mi?')
console.log(cevap, typeof cevap);
if (cevap.toLocaleLowerCase() == 'tek') {
    tur = 'Tek';
    for (let i = 0; i < sayilar.length; i++) {
        if (sayilar[i] % 2 === 1) {
            sonucDizi.push(sayilar[i])
            toplam+=sayilar[i];
        }
        
    }
}
else if (cevap.toLocaleLowerCase() == 'çift'){
    tur = 'Çift'
    for (let i = 0; i < sayilar.length; i++) {
        if (sayilar[i] % 2 === 0) {
            sonucDizi.push(sayilar[i])
            toplam+=sayilar[i];
        }
    }
}
else{
    console.log('Doğru cevap veriniz.');
}
console.log(sayilar);
console.log(sonucDizi);
console.log(toplam);