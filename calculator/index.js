
const form = document.querySelector("form");
const resultContainer = document.getElementById("resultContainer")

let selectaction=null;
form.addEventListener("submit", calculate);

function calculate(event){
    event.preventDefault();
    const num1 = Number(event.target.elements["num1"].value);
    const num2 = Number(event.target.elements["num2"].value);
    if(selectaction ==="+"){
        resultContainer.textContent=num1+num2;
    }
    else if(selectaction ==="-"){
        resultContainer.textContent=num1-num2;
    }
    else if(selectaction ==="*"){
        resultContainer.textContent=num1*num2;
    }
    else if(selectaction ==="/"){
        resultContainer.textContent=num1/num2;
    }
}

const selectAddition = () =>{
    selectaction="+";
}
const selectSubtraction = () =>{
    selectaction="-";
}
const selectMultiplication = () =>{
    selectaction="*";
}
const selectDivision = () =>{
    selectaction="/";
}