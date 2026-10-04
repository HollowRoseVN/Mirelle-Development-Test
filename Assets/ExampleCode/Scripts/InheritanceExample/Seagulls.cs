using UnityEngine;
//*** Seagull inherits from our animal Base Class which means it will have all our base attributes such as number of legs, can swim, and animal size
public class Seagulls : Animal
{
    //*** Unique Variables that will only be on  Seagulls and classes that inherit from Seagull
    public bool canFly = true;
    public bool eatsTrash = true;

}