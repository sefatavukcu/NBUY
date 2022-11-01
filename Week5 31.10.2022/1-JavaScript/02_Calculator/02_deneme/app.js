"use strict";

const display = document.querySelector('.calculator-input');
const keys = document.querySelector('.calculator-keys');
let displayValue='0';

updateDisplay();

function updateDisplay() {
    display.value=displayValue; 
}

keys.addEventListener('click',function(event){
    const element = event.target;
    if(!element.matches('button')) return;

    if (element.classList.contains('operator')) {
        console.log('operator');
    }
    else if (element.classList.contains('decimal')) {
        console.log('ondalık sayı');
    }
    else if (element.classList.contains('clear')) {
        console.log('clear');
    }
    else {
        console.log('Rakam');
    }
});