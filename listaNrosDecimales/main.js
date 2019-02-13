
//get DOM elements
const $EL_entry= document.getElementById('entry');
const $EL_logs= document.getElementById('logs');
const $EL_show= document.getElementById('show');
const $EL_numsEntered= document.getElementById('numbersEntered');
const BT_sum= document.getElementById('BT_sum');
const BT_order= document.getElementById('BT_order');

var numEntered= [];
let indexNumsEnteredId= 0;

//creates a DOM element when a number is entered
function generateNumberList(){
    
    const $numberItem= document.createElement('div')
    $numberItem.classList.add('numbersEntered')
        
    $numberItem.setAttribute('data-id', (numEntered.length-1).toString())
    $numberItem.innerHTML= `<h2>${$EL_entry.value}</h2> <button class="buttonMod">Mod</button> <button class="buttonDel">Elim</button> `
    $EL_numsEntered.firstElementChild.appendChild($numberItem)
    const item =getItemsSameID($numberItem)
    deleteEvent(item[0], item[1], $numberItem.getAttribute('data-id'), $numberItem)
    modEvent(item[0], item[2], $numberItem.getAttribute('data-id'), $numberItem)

}

//gets all the elements in the number container with the same id 
function getItemsSameID(element){
    
    const elements=$EL_numsEntered.querySelector(`div[data-id='${element.dataset.id}']`)
    
    return item=[ number= elements.querySelector('h2'),
     buttondelete= elements.querySelector('button.buttonDel'),
     buttonmod= elements.querySelector('button.buttonMod')]
 

}
/**
 * adds click event to the button
 * @param  {Element} h2
 * @param  {Element} button
 * @param  {number} id
 * @param  {HTMLDivElement} item
 */
function deleteEvent(h2,button, id, item){
    //deletes the node 
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
            modEvent(item[0], item[2], $numberItem.getAttribute('data-id'), $numberItem)
            index++ 
        });
        $EL_show.innerHTML= numEntered
        
       
    })

}
/**
 * adds click event to the button
 * @param  {Element} h2
 * @param  {Element} button
 * @param  {number} id
 * @param  {HTMLDivElement} item
 */
function modEvent(h2, button, id, item){
    //modifies the h2 to show on the HTML and the value in the array numEntered
    button.addEventListener('click',()=>{
        $EL_logs.style.visibility= 'hidden'
        const valor= prompt('Ingrese valor para modificar')
        if(!isNaN(valor) && valor != ''){
            parseInt(valor)
            h2.innerHTML= valor

            numEntered[id]= valor
            $EL_show.innerHTML= numEntered
        }else{
            $EL_logs.innerHTML= 'debe ingresar un valor numerico'
            $EL_logs.style.visibility= 'visible'
        }
    })
}

//this atribute defines if the button orders the array Desc or Asc: default Desc 
BT_order.setAttribute('direction', 'desc')

//enter on the input dialog event 
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

//click event on sum Button
BT_sum.addEventListener('click', ()=>{
    let resultado=0;

    numEntered.forEach(num => {
        resultado+=parseInt(num)
    });
    $EL_show.innerHTML= `Se sumaron: ${numEntered.length} numeros y el resultado es: <strong>${resultado}</stong>`
})
//click event on order Button
BT_order.addEventListener('click', ()=>{
    let aux= numEntered.slice()
    const orderAsc= 'Ordenar -+'
    const orderDesc= 'Ordenar +-'
    if(BT_order.getAttribute('direction')==='desc'){ 
        aux.sort(function compare(a,b){return b-a})
        BT_order.setAttribute('direction', 'asc')
        $EL_show.innerHTML= aux.slice(0,4)+ ' (primeros 4 de mayor a menor) <br/>'+ aux
        BT_order.innerHTML= orderAsc
    }
    else if(BT_order.getAttribute('direction')==='asc'){
        aux.sort(function compare(a,b){return a-b}) 
        BT_order.setAttribute('direction', 'desc') 
        $EL_show.innerHTML= aux.slice(0,4)+ ' (primeros 4 de menor a mayor) <br/>'+ aux  
        BT_order.innerHTML= orderDesc
    }
    
})





