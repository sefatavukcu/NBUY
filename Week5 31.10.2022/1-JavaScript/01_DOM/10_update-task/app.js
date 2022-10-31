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
let isEditMode = false; // Eğer bu false ise new-task modu aktif, true olursa edit-task aktif
let editedId;
btnAdd.addEventListener('click',newTask);

txtTaskName.addEventListener('keypress',function(event){
    if (event.key=='Enter') {
        event.preventDefault();
        btnAdd.click();
    }
});

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
            <div class="dropdown">
                <button class="btn btn-link dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
                <i class="fa-solid fa-ellipsis"></i>
                </button>
                <ul class="dropdown-menu">
                    <li><a onclick="removeTask(${gorev.id})" class="dropdown-item" href="#"><i class="fa-solid fa-trash-can"></i> Sil</a></li>
                    <li><a onclick="editTask(${gorev.id},'${gorev.gorevAdi}')" class="dropdown-item" href="#"><i class="fa-solid fa-pen"></i> Düzenle</a></li>
                </ul>
            </div>
        </li>
        `;
        ul.insertAdjacentHTML("beforeend",li);
    }
}

function newTask(event) {
    event.preventDefault();
    
    if (isFull(txtTaskName.value)) {
        if (!isEditMode) {
            gorevListesi.push({
                'id':gorevListesi.length + 1,
                'gorevAdi': ilkHarfBuyuk(txtTaskName.value)
            });
        }
        else{
             // Güncelleme İşlemleri
            for (const gorev of gorevListesi) {
                if (gorev.id==editedId) {
                    gorev.gorevAdi = ilkHarfBuyuk(txtTaskName.value);
                    isEditMode=false;
                    btnAdd.innerText='Ekle';
                }
            }
        }
        displayTasks();

    }else{
       alert('Lütfen boş bırakmayınız.');
        
    }
    txtTaskName.value='';
    txtTaskName.focus();
};

function isFull(value) {
    if (value.trim()=='') {
        return false;
    }
    return true;
}

function ilkHarfBuyuk(cumle){
    return cumle[0].toUpperCase() + cumle.slice(1).toLowerCase(); 
}

function removeTask(id) {
    let deleteId;
    // *******siler*****
    for (const gorevIndex in gorevListesi) {
        if (gorevListesi[gorevIndex].id==id) {
            deleteId=gorevIndex;
        }
    };
    gorevListesi.splice(deleteId,1);
    displayTasks();
}

function editTask(id,gorevAdi) {
    editedId = id;
    isEditMode=true;
    txtTaskName.value = gorevAdi;
    txtTaskName.focus();
    btnAdd.innerText = 'Kaydet'
}

displayTasks();