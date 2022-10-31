let sonuc;

//getElementById
// sonuc = document.getElementById('title');
// sonuc = document.getElementById('title').id;
// sonuc = document.getElementById('title').className;
// sonuc = document.getElementById('title').classList;

document.getElementById('title').style.fontSize='50px'; //string olarak yaz
document.getElementById('title').style.color='red';
// document.getElementById('title').style.display='none';
// console.log(sonuc);

// querySelector getelementbyid gibi ama #işaretle yazılır. ya da class olanı nokta . ile
sonuc=document.querySelector('#title');
sonuc=document.querySelector('div'); // ilk karşılaşılanı seçer
sonuc=document.querySelector('.h1');

sonuc = document.querySelector('li'); // ilk karşılaşılanı seçer.
sonuc = document.querySelector('li:first-child'); // first-child ilk elemanı seçer
sonuc = document.querySelector('li:last-child'); // last-child son elemanı seçer.
sonuc = document.querySelector('li:nth-child(2)').innerText; // kaçıncı sırayı belirtirsen o elemanı seçer.


console.log(sonuc);

