using UnityEngine;
//*** Elephant inherits from our animal Base Class which means it will have all our base attributes such as number of legs, can swim, and animal size
public class Elephant : Animal
{
    //*** Unique Variables that will only be on  Elephant and classes that inherit from Elephant
    public bool hasTrunk = true;
    public bool livesInJungle;
}
