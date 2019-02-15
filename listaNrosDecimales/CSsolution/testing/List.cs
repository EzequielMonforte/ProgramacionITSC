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
    /// Sum all values in the list
    /// </summary>
    /// <returns></returns>
    public int SumValues(){
        int result=0;
        foreach (var value in listShow)
        {
            result += value;
        }
        return result;
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
/// <summary>
/// Returns a list with all the nums entered
/// </summary>
/// <returns></returns>
    public List<int> AllNumbers(){
        return listStorage;
    }
/// <summary>
/// Removes the number with the specified index
/// </summary>
/// <param name="index"></param>
/// <returns>returns true if the number was removed false if not</returns>
    public bool RemoveNumber(int index){
        try{
        listShow.RemoveAt(index);
        return true;
        }
        catch{
            return false;
        }
    }
    /// <summary>
    /// Modifies the value in the list 
    /// </summary>
    /// <param name="index">list index</param>
    /// <param name="value">new value</param>
    /// <returns></returns>
    public bool ModifieNumber(int index, int value){
        if(index < 0){
            throw new Exception("index less than 0");
        }else{
        listShow[index]= value;
        return true;
        }
    }
}

    

}
