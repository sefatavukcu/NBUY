let sonuc;

//getElementById
// sonuc = document.getElementById('title');
// sonuc = document.getElementById('title').id;
// sonuc = document.getElementById('title').className;
// sonuc = document.getElementById('title').classList;

// document.getElementById('title').style.fontSize='50px'; //string olarak yaz
// document.getElementById('title').style.color='red';
// document.getElementById('title').style.display='none';
// console.log(sonuc);

// querySelector getelementbyid gibi ama #işaretle yazılır. ya da class olanı nokta . ile
// sonuc=document.querySelector('#title');
// sonuc=document.querySelector('div'); // ilk karşılaşılanı seçer
// sonuc=document.querySelector('.h1');

// sonuc = document.querySelector('li'); // ilk karşılaşılanı seçer.
// sonuc = document.querySelector('li:first-child'); // first-child ilk elemanı seçer
// sonuc = document.querySelector('li:last-child'); // last-child son elemanı seçer.
// sonuc = document.querySelector('li:nth-child(2)').innerText; // kaçıncı sırayı belirtirsen o elemanı seçer.

// getElementsByClassName ----> Geriye birden çok element geriye döndürebilir.

sonuc = document.getElementsByClassName('card-header');
sonuc = document.getElementsByClassName('task');
sonuc = document.getElementsByClassName('task')[0].innerText;
sonuc = document.getElementsByClassName('task')[2].innerText;
sonuc = document.getElementsByClassName('task');
// for (let i = 0; i < sonuc.length; i++) {
//     console.log(sonuc[i].innerText);
// }

let taskList = document.getElementsByClassName('task');

// for (const task of taskList) {
//     task.style.color='red';
//     task.style.fontSize='60px';
//     task.innerText='ITEM';
// }

let taskList2 = document.getElementById('task-list2'); // tek değer döndürür,ilk karşılaşılan
// sonuc = taskList2.getElementsByClassName('task');
sonuc = taskList2.getElementsByTagName('li'); // geriye birden çok sonuç döndürebilir.

sonuc = document.querySelectorAll('#task-list2 li'); // geriye birden çok sonuç döndürür.

for (const task of sonuc) {
    task.style.backgroundColor='navy';
    task.style.color='white';
}

console.log(sonuc);

