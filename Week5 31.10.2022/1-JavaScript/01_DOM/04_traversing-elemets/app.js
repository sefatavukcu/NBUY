let sonuc;

// let tasklist = document.getElementById('task-list')
// sonuc = tasklist.children;
// sonuc = tasklist.children[0];
// sonuc = tasklist.firstElementChild;
// sonuc = tasklist.lastElementChild.innerText;

// sonuc = document.getElementById('title');
// sonuc = sonuc.parentElement.parentElement.parentElement;

taskList = document.querySelector('.task');
// sonuc = taskList.nextElementSibling.nextElementSibling;  // sıradaki elemente geçer
// sonuc = sonuc.previousElementSibling;  // kendisinden bir öncekine git

let ul = document.getElementById('task-list')
sonuc = ul.children;
sonuc = ul.children[0].children[0].children[0].checked=true;
console.log(sonuc);

