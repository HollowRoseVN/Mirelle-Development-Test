using UnityEngine;

//*** I wanted to give you an example of a script with multiple levels of inheritance MAmmoth will have ALL the values of Animal AND Elephant
public class Mammoth : Elephant
{
    //*** This variable will only show up on Mammoth
    public bool isAncient = true;
}
