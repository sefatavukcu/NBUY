let simdi = new Date();
sonuc = simdi,

sonuc = simdi.getDate();
console.log(sonuc);

sonuc = simdi.getDay();
console.log(sonuc);

sonuc = simdi.getFullYear();
console.log(sonuc);

sonuc = simdi.getHours();
console.log(sonuc);

sonuc = simdi.getTime();
console.log(sonuc);

simdi.setFullYear(2015);
sonuc=simdi;
simdi.setMonth(3);
sonuc=simdi;
simdi.setHours(17);
console.log(sonuc);

let now = new Date();
sonuc = now;
sonuc = sonuc.getFullYear()+1;
console.log(sonuc);





simdi = new Date();
sonuc = simdi;
let dgt = new Date(2000,0,13);

console.log(dgt);
console.log(sonuc);

simdi = new Date();
sonuc = simdi.getFullYear()-dgt.getFullYear();
console.log(dgt);
console.log(sonuc);

let ms = simdi - dgt;
console.log(dgt);
console.log(ms);

let second = ms/1000 ;
console.log(dgt);
console.log(second);

let minutes = second/60 ;
console.log(dgt);
console.log(minutes);

let hour = minutes/60 ;
console.log(dgt);
console.log(hour);

let day = hour/24 ;
console.log(dgt);
console.log(day);

let months = day/30 ;
console.log(dgt);
console.log(months);