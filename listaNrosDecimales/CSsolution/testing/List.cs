using System;
using System.Collections;
using System.Collections.Generic;

namespace Listas{
public class List{
    private List<int> listShow;
    private List<int> listStorage;

    public List(){
        listShow= new List<int>();
        listStorage= new List<int>();
 
    }

    public void addNumber(int num){
        listStorage.Add(num);
        listShow.Add(num);
    }

    public List<int> ShowList(){
        return listShow;
    }

    public List<int> ShowOrderList(){
        List<int> orderList= new List<int>(listShow);
        //todo: order array
         orderList.Sort((int a, int b)=>{return (a-b);});
         return orderList;
    }
}
}
