// let urunler = [];
// urunler[0] = "Samsung S21"
// urunler[1] = "IPhone 13"
// urunler[2] = "IPhone 14"
// urunler[123] = "Monster Notebook"

// let urunler = ['IPhone 13', 'Xiaomi', 'Monster','Asus']
// let fiyatlar = [15000,9000,23000,19000]
// let renkler = ['Kırmızı', 'Gri', 'Siyah', 'Mavi']
// console.log(urunler);
// console.log(fiyatlar);
// console.log(renkler);

// urunler.forEach((urun, i)=>{
//     console.log(urun, fiyatlar[i], renkler[i]);
// });

// let urun1 = [];
// urun1[0]='IPhone 13';
// urun1[1]=25000;
// urun1[2]='Gri';
// urun1[3]=true;

// let urun2 =[]
// urun2[0]='Monster';
// urun2[1]=28500;
// urun2[2]='Siyah';
// urun2[3]=false;

// let urun3 = ['Dell',19000,'Kırmızı',true]

// console.log(urun1, typeof urun1);
// console.log(urun2, typeof urun2);
// console.log(urun3, typeof urun3);



// let urunler = [urun1, urun2, urun3]

// console.log(urunler, typeof urunler);


// let urun1 = 'IPhone 13, 25000, Gri, true';
// let urun1d = urun1.split(', ');
// console.log(urun1, typeof urun1);
// console.log(urun1d, typeof urun1d);

// let ogrenciler = ['Cemre','Melahat','Sema','Hasancan']
// let sonuc;
// sonuc = ogrenciler.length;
// sonuc=ogrenciler;
// console.log(sonuc);

// sonuc= ogrenciler.toString();
// console.log(sonuc);

// sonuc= ogrenciler.join('---');
// console.log(sonuc);


// ogrenciler[4]='Serhat';
// console.log(ogrenciler);

// ogrenciler.push('Aylin');
// console.log(ogrenciler);

// ogrenciler.pop();
// console.log(ogrenciler);

// sonuc = ogrenciler.push('Aylin')
// sonuc = ogrenciler.pop()
// console.log(sonuc);

// sonuc=ogrenciler.unshift('Aylin');
// console.log(sonuc);
// console.log(ogrenciler);

let sonuc;
let markalar1 = ['Mazda','Toyota','Subaru'];
let markalar2 = ['TOGG','Mitsubishi'];
let markalar3 = ['Volvo'];
console.log(markalar1);
console.log(markalar2);
console.log(markalar3);

sonuc = markalar1.concat(markalar2) // Birleştirme
console.log('Sonuç: ' + sonuc);

sonuc = markalar1.concat(markalar2,markalar3);
console.log('Sonuç: ' + sonuc);

sonuc = markalar1.splice(0,1);  // Silineni yazdırır. ve diziden çıkartır. istenilen yerden istenildiği kadar eleman
console.log('Sonuç: ' + sonuc);


