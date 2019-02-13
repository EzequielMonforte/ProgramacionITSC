using System;
using System.Collections;
using System.Collections.Generic;

public class List{
    private List<int> listShow;
    private List<int> listStorage;

    public List(){
        listShow= new List<int>();
        listStorage= new List<int>();
 
    }

    public void addNumber(int num){
        listStorage.Add(num);
        listStorage.Add(num);
    }

    public List ShowList(){
        return listShow;
    }

    public List ShowOrderList(){
        List<int> orderList= listShow.MemberwiseClone();
        //todo: order array
    }
}