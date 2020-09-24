using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Shape_4 : MonoBehaviour
{
    public BonusType_4 Bonus { get; set; }
    public BonusType_4 Bigbonus { get; set;  }
    public int Column { get; set; }
    public int Row { get; set; }
    public bool Is_Bomb = false;
    public bool Is_BigBomb = false;
    public  string Type { get; set; }
    public string hello;

    public Shape_4()
    {
        Bonus = BonusType_4.None;
        Bigbonus = BonusType_4.None;
    }
    



    /// Checks if the current shape is of the same type as the par bameter
    public bool IsSameType(Shape_4 otherShape)
    {
        if (otherShape == null || !(otherShape is Shape_4))
            throw new ArgumentException("otherShape");

              
   
        return string.Compare(this.Type, (otherShape as Shape_4).Type) == 0;
    }

    
    

   
    /// Constructor alternative
    public void Assign(string type, int row, int column)
    {

        if (string.IsNullOrEmpty(type))
            throw new ArgumentException("type");
       
        
       

        Column = column;
        Row = row;
        Type = type;
        hello = Column + " " + Row + " " + Type;
    }
   

    
   

    /// Swaps properties of the two shapes
    /// We could do a shallow copy/exchange here, but anyway...
    public static void SwapColumnRow(Shape_4 a, Shape_4 b)
    {
        int temp = a.Row;
        a.Row = b.Row;
        b.Row = temp;

        temp = a.Column;
        a.Column = b.Column;
        b.Column = temp;
    }
}



