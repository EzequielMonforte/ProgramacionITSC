const $EL_entry= document.getElementById('entry');
const $EL_logs= document.getElementById('logs');
const $EL_show= document.getElementById('show');
const $EL_numsEntered= document.getElementById('numbersEntered');
const BT_sum= document.getElementById('BT_sum');
const BT_order= document.getElementById('BT_order');

var numEntered= [];
let indexNumsEnteredId= 0;

BT_order.setAttribute('direction', 'desc')

$EL_entry.addEventListener('keypress', (event)=> {
    if(event.key === 'Enter'){
        
        if(!isNaN($EL_entry.value) && $EL_entry.value != ''){
            
        $EL_logs.style.visibility= 'hidden'
        numEntered.push($EL_entry.value)
        
        generateNumberList(numEntered)

        //todo: modEvent(item[0], item[1])
        indexNumsEnteredId+= 1;
        $EL_entry.value= null
        }else{
       
            $EL_logs.innerHTML= 'debe ingresar un valor numerico'
            $EL_logs.style.visibility= 'visible'

        }
}
})
function generateNumberList(){
    
        
    const $numberItem= document.createElement('div')
    $numberItem.classList.add('numbersEntered')
        
    $numberItem.setAttribute('data-id', (numEntered.length-1).toString())
    $numberItem.innerHTML= `<h2>${$EL_entry.value}</h2> <button class="buttonMod">Mod</button> <button class="buttonDel">Elim</button> `
    $EL_numsEntered.firstElementChild.appendChild($numberItem)
    const item =getItemsSameID($numberItem)
    deleteEvent(item[0], item[1], $numberItem.getAttribute('data-id'), $numberItem)

}

BT_sum.addEventListener('click', ()=>{
    let resultado=0;

    numEntered.forEach(num => {
        resultado+=parseInt(num)
    });
    $EL_show.innerHTML= `Se sumaron: ${numEntered.length} numeros y el resultado es: <strong>${resultado}</stong>`
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
    $EL_show.innerHTML= aux.slice(0,4)+ '<br/>'+ aux
})

function getItemsSameID(element){
    
    const elements=$EL_numsEntered.querySelector(`div[data-id='${element.dataset.id}']`)
    
    return item=[ number= elements.querySelector('h2'),
     buttondelete= elements.querySelector('button.buttonDel'),
     buttonmod= elements.querySelector('button.buttonMod')]
 

}

function deleteEvent(h2,button, id, item){
    button.addEventListener('click', ()=>{

        console.log(numEntered.splice(id,1))
        const child=$EL_numsEntered.childElementCount
        $EL_numsEntered.removeChild(document.getElementById('contenedor'))

        const $container= document.createElement('div')
        $container.id= 'contenedor'
        $EL_numsEntered.appendChild($container)
        let index=0;
        numEntered.forEach(element => {
            const $numberItem= document.createElement('div')
            $numberItem.classList.add('numbersEntered')
                
            $numberItem.setAttribute('data-id', (index).toString())
            $numberItem.innerHTML= `<h2>${element}</h2> <button class="buttonMod">Mod</button> <button class="buttonDel">Elim</button> `
            $EL_numsEntered.firstElementChild.appendChild($numberItem)
            const item =getItemsSameID($numberItem)
            deleteEvent(item[0], item[1], $numberItem.getAttribute('data-id'), $numberItem)
            index++
        });

        
       
    })
}








