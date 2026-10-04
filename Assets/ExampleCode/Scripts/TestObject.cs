using UnityEngine;

//*** This script is called an " object" and objects are like custom containers for different data you may want to edit in your game

//*** The serializable tag  makes it possible to see this object in the unity inspector
[System.Serializable]
public class TestObject //our other script inherits from Monobehvaior , objects DO NOT inherit from anything
{
    //*** This field hods our cube gameobjects which we activate when the object is randomly selected
    public GameObject coloredCube;

    //*** This value holds the character name
    public string characterName = "";

    //*** This line holds our character age integer
    public int characterAge = 24;

    //*** This is the boolean we enable after a randomized object has been selected to note the given character has " spoken" in the editor
    public bool characterHasSpoken = false;

    //*** This string holds our sentence value
    public string characterDialogue = " What will I say?";
}
