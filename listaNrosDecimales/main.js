const EL_entry= document.getElementById('entry');
const EL_logs= document.getElementById('logs')
const EL_show= document.getElementById('show');
const BT_sum= document.getElementById('BT_sum');
const BT_order= document.getElementById('BT_order')

var numEntered= [];

BT_order.setAttribute('direction', 'desc')

EL_entry.addEventListener('keypress', (event)=> {
    if(event.key === 'Enter'){
        
        if(!isNaN(EL_entry.value)){
            
        EL_logs.style.visibility= 'hidden'
        numEntered.push(EL_entry.value)
        EL_entry.value= null
        EL_show.innerHTML= numEntered
        
        }else{
       
            EL_logs.innerHTML= 'debe ingresar un valor numerico'
            EL_logs.style.visibility= 'visible'

        }
}
})

BT_sum.addEventListener('click', ()=>{
    let resultado=0;

    numEntered.forEach(num => {
        resultado+=parseInt(num)
    });
    EL_show.innerHTML= `Se sumaron: ${numEntered.length} numeros y el resultado es: <strong>${resultado}</stong>`
})

BT_order.addEventListener('click', ()=>{
    let aux= numEntered.slice()
    const orderAsc= 'Ordenar -+'
    const orderDesc= 'Ordenar +-'
    if(BT_order.getAttribute('direction')==='desc'){
        aux.sort(function compare(a,b){return b-a})
        BT_order.setAttribute('direction', 'asc')
        BT_order.innerHTML= orderAsc
    }
    else if(BT_order.getAttribute('direction')==='asc'){
        aux.sort(function compare(a,b){return a-b}) 
        BT_order.setAttribute('direction', 'desc')   
        BT_order.innerHTML= orderDesc
    }
    EL_show.innerHTML= aux.slice(0,4)+ '<br/>'+ aux
})






