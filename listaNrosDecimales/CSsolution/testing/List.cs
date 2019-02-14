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
    /// <summary>
    /// Adds a number to the list
    /// </summary>
    /// <param name="num"></param>
    public void addNumber(int num){
        listStorage.Add(num);
        listShow.Add(num);
    }
/// <summary>
/// Shows all the list of number entered
/// </summary>
/// <returns></returns>
    public List<int> ShowList(){
        return listShow;
    }

/// <summary>
/// Returns a list ordered from numbers entered
/// </summary>
/// <param name="Order"> if true orders list asc if false desc</param>
/// <returns></returns>
    public List<int> ShowOrderList(bool order){
        List<int> orderList= new List<int>(listShow);
        //todo: order array
        if(order){
         orderList.Sort((int a, int b)=>{return (a-b);});
        }else{
            orderList.Sort((int a, int b)=>{return (b-a);});
        }
         return orderList;
    }
}
}
