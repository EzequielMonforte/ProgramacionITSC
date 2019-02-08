const EL_entry= document.getElementById('entry');
const EL_logs= document.getElementById('logs')
const EL_show= document.getElementById('show');
const BT_sum= document.getElementById('BT_sum');
const BT_order= document.getElementById('BT_order')

var numEntered= [];

BT_order.setAttribute('direction', '')

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

BT_order.addEventListener('click', (event)=>{

})






