/* 
    EcmaScript    

    Değişkenler tanımlanırken 3 farklı keyword kullanlabilir.
    1) var
    2) let
    3) const(sabit)

    ES6 ile birlikte artık modern javascript tabiri kullanılmaya başlanmıştır.
    Bu süreçte let ve const kullanın, var kullanmaktan kaçının.

    js de değişken tanımlanırken tip belirtilmez
    Bu değişkenleri tipi olmadığı anlamına gelmez.
    js motoru bir değişkene değer atanması esnasında o değere göre tipi belirler.
    tip hassasiyeti yok
    Eğer henüz bir değişkene değer atanmamışsa undefined olarak belirlenir

*/

// let a =20;
// console.log(a);

// let ad = 'Geç kalan sema';
// let soyad = 'Geç kalan harun';
// console.log(ad,soyad);
// console.log(ad)
// console.log(soyad)

// let firstName = 'Serhat';
// let lastName = 'Kaya';
// console.log(firstName + ' ' + lastName);

// let sayi1 = 15;
// let sayi2 = 25;
// let sayi3 = 35;

// let s1 = 15, s2 = 45, s3=55;

// let say1 = 25,
//     say2 = 35,
//     say3 = 45;

// let durum = true;
// let durum2 = false;

// sayi1=125;
// console.log(say1);



// const dgy = 1975;
// console.log('Benim doğum yılım: ' + dgy);

/*
    Bildiğimiz değişken isimlendirme yöntemlerini burada da kullanabiliriz.
    Değişkenler genellikle camelCase ile isimlendirilir.
    Değişken isminde harf, rakam, $ ve _ olabilir.
    Değişken ismi rakamla başlayamaz.
    Reserved Keywordler değişken adı olarak kullanılmaz.

    Const sabit değerleri tutmak için kullanılır. Genellikle tamamen 
    büyük harf ile isimlendirilir.
*/

// const PI_SAYISI = 3.14;
// const _PI_SAYISI = 3.14;

// const RENK_1 = 'Kırmızı'
// const RENK_2 = 'Sarı'
// let renk_3 = 'Yeşil'

// console.log(RENK_1, RENK_2, renk_3);


//DATA TYPES

//1-Number

// let say1 = 100;
// console.log(say1);
// console.log(typeof say1);
// console.log(typeof(say1));

// let say2 = 17.5;
// console.log(say2, typeof say2);
// console.log(typeof say2);

// let say3 = 25/0;
// console.log(say3, typeof say3);

// let say4 = 'Okul' /25;
// console.log(say4, typeof say4);

// // sayıların hepsini görmek için sayıların sonuna n harfi eklenir

// let say5 = 99999999999999999999999999999999999999999999999999999999999999999999999999999999999944151515615616464465153156164651561641648641561644615616486165165688417854784514856251485148561n;
// console.log(say5, typeof say5);

// let say6 = say5* 99999999999999999999999999999999999999999999999999999999999999999999999999999999n;
// console.log(say6, typeof say6);

//String

/*

    String ifadeler üç farklı şekilde ifade edilebilir.
    1) Tek tırnak ile ''
    2) Çift tırnak ile ""
    3) Backticks `` 

*/

// let ad = 'Engin';
// let soyad = '\'Niyazi\'';
// let adSoyad = ad + " " + soyad;
// console.log(adSoyad);

// let adres = 'Halit Ağa Mah.\n\tSütlü Nuriye Sok. Candaş Apt. No:21 \n\tBeşiktaş'
// console.log(adres);

// let adSoyad = 'Sefa Tavukçu';
// let yas = 22;
// let kanGrubu = 'BRh+'
// let kilo = 80;
// let cinsiyet = 'erkek'

// console.log('Sayın ' + adSoyad + ', ' + yas + ' yasındasınız.\n Kilo: ' +kilo);

// console.log(`Sayın ${adSoyad}, ${yas} yaşındasınız.`) // `` bu işaretin içine yazılır.

//BOOLEAN

// let durum = true;
// console.log(durum, typeof(durum));
// let ad = 'Halil';
// console.log(ad, typeof ad);


// Null, Undefined

// let yas;
// yas = null;
// yas = 12/0;
// console.log(yas, typeof yas);

// JS de char diye bir tip yoktur.

// Convert data types

// let durum = false;
// console.log(durum, typeof durum);

// let metin = 'durumunuz ' + durum + ' seklindedir.';
// console.log(metin, typeof metin);

// let durumMetin = String(durum);
// console.log(durumMetin, typeof durumMetin);

// let sayi = 25;
// let metin2= sayi + ' yaşındasınız.'
// console.log(metin2);
// let sayi_metin2 = String(sayi)
// console.log(sayi_metin2, typeof sayi_metin2);

// let metSay = '459';
// console.log(metSay, typeof metSay);
// let metSayN = Number(metSay);
// console.log(metSayN, typeof metSayN);


// let sayiMetin = '    145     ';
// console.log(sayiMetin, typeof sayiMetin);
// let sayi = Number(sayiMetin);
// console.log(sayi, typeof (sayi));

// number: (2^53)-1 kadardır.

// let sayi = 12365n;
// console.log(sayi, typeof sayi);

// console.log(Number(true));
// console.log(Number(false));

// Bool sadece sayı olan 0'ı false alır
// Geri kalanları true alır.

// console.log(Boolean(0));
// console.log(Boolean(1));
// console.log(Boolean(56256));
// console.log(Boolean(-452));
// console.log(Boolean('0'));


// 1) string bir sayı ile toplama yaparsa birleştirir.
// 2) string bir sayı ile çıkarma yaparsa number olarak kabul eder ve çıkarma işlemi yapılır.(İşlem neyse o)
// 3) 1 ile 0 toplanmış gibi oluyor.
// 4) Bölme işlemi metin birleştirme yapmayacağı için string ifadeyi numbere çevirip işlemi yapar.
// 5) İşlem soldan sağa gittiğinden önce toplar sonra stringi ekler. (İşleme göre devam eder. İlk başta hangisi varsa diyebiliriz.)
// 6) İşlem soldan sağa gittiğinden önce stringi ekler ve sayıları birleştirir. (Parantez işlemi açarak matematiksel öncelikleri verebiliriz.)
// 7) Stringten bir sayı çıkaramayacağı için sayı değildir olarak algılar.
// 8) String birleştirme yaptı. (- / gibi ifadeler olunca stringi sayıya çevirmeye çalışır ve öyle işleme tabii tutar.)
// 9) null 0 anlamına gelir. içinde bir şey olmayan obje . Çarpılma işlemi yapılınca 0 çıkar
// 10) Undefined ile hiçbir şeyi toplanamaz. Çünkü ne olduğu neyi ifade ettiği belli değil. 

// Açıklama yukarıda 

// let a;
// a = '' + 1 + 0; console.log(a, typeof a);
// a = '' - 1 + 0; console.log(a, typeof a);
// a = true + false; console.log(a, typeof a);
// a = 6 / '3'; console.log(a, typeof a);
// a = 4+5+ 'px'; console.log(a, typeof a);
// a = '$'+4+5; console.log(a, typeof a);
// a = '4px'-2; console.log(a, typeof a);
// a = '    -9     ' + 5; console.log(a, typeof a);
// a = null+1; console.log(a, typeof a);
// a = undefined+1; console.log(a, typeof a);

















