'use strict'; // let kullanmak zorunlu

let gorevListesi = [
    {'id':1, 'gorevAdi':'Görev 1'},
    {'id':2, 'gorevAdi':'Görev 2'},
    {'id':3, 'gorevAdi':'Görev 3'},
    {'id':4, 'gorevAdi':'Görev 4'},
    {'id':5, 'gorevAdi':'Görev 5'}
];

let btnAdd = document.getElementById('btnAddNewTask');
let txtTaskName = document.getElementById('txtTaskName');
btnAdd.addEventListener('click',newTask);

txtTaskName.addEventListener('keypress',function(event){
    if (event.key=='Enter') {
        event.preventDefault();
        btnAdd.click();
    }
})


function displayTasks() {
    let ul = document.getElementById('task-list');
    ul.innerHTML='';  // html e gösterirken içini boşaltıyor herhalde
    for (const gorev of gorevListesi) {
        let li = `
        <li class="task list-group-item">
            <div class="form-check">
                <input type="checkbox" id="${gorev.id}" class="form-check-input">
                <label for="${gorev.id}" class="form-check-label">${gorev.gorevAdi}</label>
            </div>
        </li>
        `;
        ul.insertAdjacentHTML("beforeend",li);
    }
}

function newTask(event) {
    event.preventDefault();
    
    if (isFull(txtTaskName.value)=='') {
        gorevListesi.push({
            'id':gorevListesi.length + 1,
            'gorevAdi': ilkHarfBuyuk(txtTaskName.value) // Ödev: Her kelimenin ilk harfini büyütecek fonksiyonu yazın.
        });
        displayTasks();

    }else{
        alert('Lütfen boş bırakmayınız...');
    }
    txtTaskName.value='';
    txtTaskName.focus();
};


function isFull(value) {
    if (value.trim()=='') {
        return true;
    }
    return false;
}

function ilkHarfBuyuk(cumle){
    return cumle[0].toUpperCase() + cumle.slice(1).toLowerCase(); 
}

displayTasks();