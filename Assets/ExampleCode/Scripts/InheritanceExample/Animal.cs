using UnityEngine;


/// <summary>
/// *** This is our base animal class all the other animal scripts " inherit" or hold the properties of this class PLUS the unique values defined in them
/// </summary>
public class Animal : MonoBehaviour
{
  [SerializeField]  protected string animalNickname = "";

    public int numberOfLegs;
    public bool canSwim;
    
    public enum animalSize
    {
        none,
        tiny,
        small,
        medium,
        large
    }

    public animalSize currentAnimalsSize;
}
