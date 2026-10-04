using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ExampleScript : MonoBehaviour
{
    // <- These Two lines denote text that IS NOT machine readbale we call these comments and they are super useful whe nyou want to track the reason and logic behind certain system and design decisions

    // First let's describe Accessors these are how we define how visible a "member"  such as a function or variable is to other scripts inside of this projectNumber =
    //Private - Means no other script except this script needs to see the variable or function
    //Public means ANY script that has access to this class , variable, or function will be able to call or access it
    //Protected deals with inheritance and inheritance which i'll touch upon in another script

    //*** Because this is private you will not see it in the inspector andn o other script will know about this particular variable
    //*** When set set a value in the script we are "initializing it" meaning setting its starting value we can modify the "public" variables in the Unity inspector
    private int invisibleNumber = 1234567891;


    //*** This is a Header Attribute used to help more clearly organize and highlight different sections of code 
    [Header(" Example Variables")]

    //*** This tool tip attributewhich  makes it so if you hover over a variable in the inspector it reports why or when you may want to modify a specific variable
    [Tooltip("Turn this on to output test variables in the console!!!")]
    public bool renderTestVariables;

    //*** Booleans are True / False checks and show up as checkboxes i nthe unity editor sometimes they are also called flags
    //but there state is always binary  true or false historyically they would be considered 0's or 1's
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool
    public bool testBoolean = false;


    // Declaration of variables

    //*** Characters are text values that contain a single letter, not as commonly used but would be applicabble for something like a multiple choice test application or quiz show game
   // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char
    public char testCharacter = 'A';

    //*** Strings are a collection of Characters and can include many letters , full  sentences paragraphs of  characters if desired

    //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
    public string testString = " Ooh wee I'm a string !!!!!";

    //*** Integers are whole numbers with no decimal point , useful for values like scores, experience points, or indexes in a colelction or array
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
    public int testInteger = 0;

    //*** Doubles are decimal point values with two decimal places, useful for managing things like currency or time values 
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
    public double testDouble =  1.90;

    //*** Floas are floating point vlaues which are numbers with multiple decimal points, useful for values yo ureally need to fine-tune such as physics force or really precise positionso f an object within a scene
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
    public float testFloat = 1.7456389f;

    [Header("Enumerator Examples")]
    public bool DisplayCurrentRoomType;
    //*** This is an enumerator and it is useful whe nyou want to create categories to check values against
    public enum roomType: int
    {
         home = 0,
         party = 1,

         park = 2,

         beach = 3
    }

    public roomType currentRoomType;

    [Header(" Collection Examples")]
    public bool displayRandomCharacterAndCubeExamples;

    // Arrays are a fixed size collection of data so an array
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
    public TestObject[] characterExampleArray = new TestObject[4];

    //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-10.0
    public List<TestObject> characterExampleList = new List<TestObject>();


    // Youu will see another script in the folder next to this script , I will reference it here , we call that an object
    [Header(" And / OR Test Variables")]
    public bool thisBoolIsTrue = true;
    public bool thisBoolIsTrueAlso = true;

    [Header(" Timer Example Variables")]
    public bool outputTimeValue = false;
    public float timerUpdateInterval = 2f;
    private float timerUpdateCounter = 0f;

    [Header(" Random number Generator variables")]
    public bool TestRandomNumberGenerator = true;
    public int minimumNumber;
    public int maximumNumber;

    private int randomizedNumber;


    [Header(" Vector Example variables")]
    public bool TestOutputVectorValues;
    //*** A Vector2 is a data set that contains two floating pair values specifically  an (X,Y) value pair, useful for placing objects within something like a UI canvas,
    //moving this within a grid type position and objects in 2D Space
    public Vector2 exampleVector2 = new Vector3(8f, 16f);

    //*** A Vector3 is a data set that contains three floating values specifically  an (X,Y,Z) value set,
    //useful for placing objects within something like world space coordinates, managing object rotations, and objects in 3D space

    public Vector3 exampleVector3 = new Vector3(1f, 2f, 3f);

    [Header(" MultipleChoiceSwitchStatementTest")]
    public bool testExampleSwitchStatement = false;
    public Char multipleChoiceTestAnswer = 'A';

    public List<Animal> Zoo = new List<Animal>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //*** Start is an example of  what we call a method  basically a smaller container where we handle specific code.  
    void Start()
    {

        //*** when we inclue two equals signs like so "=="  We are making a compariosn statement and these comparison statements allow us ot check if something is true or false and build systems reflecting 
        // various values

        //*** If Render Test Variables is true then Display test variable values in our console log window
        if (renderTestVariables == true)
        {
            //*** This is an example of what we call a Function Call  when we include a function name followed by parentheses and a semi colon we are basically telling the script NOW is when we should 
            //Execute the following code
            DisplayTestVariablesInLog();
        }

        if (DisplayCurrentRoomType == true)
        {

            DisplayCurrentRoomTypeInLog();
        }

        if(displayRandomCharacterAndCubeExamples == true)
        {

            DisplayRandomCharacterAndCube();

        }

        if(TestRandomNumberGenerator == true)
        {

            DisplayRandomNumber();

        }

        if (TestOutputVectorValues)
        {
            TestOutPutVectorValues();

        }

        if (testExampleSwitchStatement)
        {

            DisplayExampleSwitchStatement();
        }

        TestAndORBooleans();
    }

    // Update is called once per frame
    void Update()
    {
        //Incremet our timer update value by our Time.deltTime value which updates every frame we when we do this we take our existing time value and add onto it continuously
        timerUpdateCounter = timerUpdateCounter + Time.deltaTime;

        //*** We check how much time has passed and if it has passed our timed interval value AND we check if our OutputTimeValue flag i enabled 
        if(timerUpdateCounter >= timerUpdateInterval && outputTimeValue == true)
        {
            //*** IMPORTANT In situations like timers we have to make sure we reset the time value back to zero when our time value meets or exceeds it so that we can begin a new 2 second count
            timerUpdateCounter = 0f;

            //*** If both of the above are true output time values
            DisplayTimerUpdate();
        }

    }


    public void DisplayTestVariablesInLog()
    {
        // When we want to convert a variable to a seting we add our variable name .ToString() and we can "append" our add full phrases for our logs by adding text in quotes PLUS our valu.ToString()
        Debug.Log(" Example Variable Test Boolean == " + testBoolean.ToString());
        Debug.Log(" Example Variable Test Character == " + testCharacter.ToString());

        //*** Just noting that because our value is already a string we don't need to convert it to a string
        Debug.Log(" Example Variable Test String == " + testString);


        Debug.Log(" Example Variable TestInteger == " + testInteger.ToString());
        Debug.Log(" Example Variable TestDouble == " + testDouble.ToString());
        Debug.Log(" Example Variable TestFloat == " + testFloat.ToString());
    }


    public void DisplayCurrentRoomTypeInLog()
    {
        switch (currentRoomType)
        {
            case roomType.beach:


                Debug.Log("Current Room type is the Beach !");
                break;


            case roomType.home:


                Debug.Log("Current Room type is the Home !");
                break;


            case roomType.park:


                Debug.Log("Current Room type is the Park !");
                break;


            case roomType.party:


                Debug.Log("Current Room type is the Party !");
                break;


            default:

                Debug.Log(" Current Room type is not one of the selected types !");
                break;
        }
    }

    public void DisplayRandomCharacterAndCube()
    {
        //*** When it comees to collections it's best to think of them as a group of containers and the very first container is Container [0]
        ////that number in between the brckets is clled an index and the index correlates to a position within the collection

        //*** Below we get random numbers and we base it on the size of the collections themselves

        //*** Arrays area  fixed size collection meaning  at runtime if we say we only want 4 containers  it will only be able to contain 4 of whatever value is assigned to this collection
        int randomCharacterArrayIndex =  UnityEngine.Random.Range(0,characterExampleArray.Length);

        Debug.Log(
            " The Random Array index we selected was at index [" + randomCharacterArrayIndex.ToString() + "] " +
            " Character Name : " + characterExampleArray[randomCharacterArrayIndex].characterName +
            " Character Age : " + characterExampleArray[randomCharacterArrayIndex].characterAge +
            " Character Dialogue : " + characterExampleArray[randomCharacterArrayIndex].characterDialogue
            );

        //*** Mark which random characters have spoken
        characterExampleArray[randomCharacterArrayIndex].characterHasSpoken = true;

        if (characterExampleArray[randomCharacterArrayIndex].coloredCube != null)
        {
            //*** We activate the cube gameobject assigned to this character
            characterExampleArray[randomCharacterArrayIndex].coloredCube.SetActive(true);

            Debug.Log(characterExampleArray[randomCharacterArrayIndex].characterName + "'s  cube is activated");
        }
        else
        {
            Debug.Log(characterExampleArray[randomCharacterArrayIndex].characterName + "'s  cube is missing!!!");
        }


        int randomCharaterListIndex = UnityEngine.Random.Range(0, characterExampleList.Count); ;


        Debug.Log(
           " The Random List index we selected was at index [" + randomCharaterListIndex.ToString() + "] " +
           " Character Name : " + characterExampleList[randomCharaterListIndex].characterName +
           " Character Age : " + characterExampleList[randomCharaterListIndex].characterAge +
           " Character Dialogue : " + characterExampleList[randomCharaterListIndex].characterDialogue
           );

        //*** Mark which random characters have spoken
        characterExampleList[randomCharaterListIndex].characterHasSpoken = true;

        if (characterExampleArray[randomCharacterArrayIndex].coloredCube != null)
        {
            //*** We activate the cube gameobject assigned to this character
            characterExampleList[randomCharaterListIndex].coloredCube.SetActive(true);
            Debug.Log(characterExampleList[randomCharaterListIndex].characterName + "'s  cube is activated");
        }
        else
        {

            Debug.Log(characterExampleList[randomCharaterListIndex].characterName + "'s  cube is missing !!!");
        }
    }

    public void DisplayTimerUpdate()
    {

        Debug.Log(timerUpdateInterval.ToString() + " Seconds has passed  Creating new log !");

    }


    public void DisplayRandomNumber()
    {

        randomizedNumber = UnityEngine.Random.Range(minimumNumber, maximumNumber);
        Debug.Log(" Random Number updated now randomizedNumber == " + randomizedNumber.ToString() + " will be between " + minimumNumber.ToString() + " and " + maximumNumber.ToString());

    }


    public void TestAndORBooleans()
    {
        //*** If Both of these booleans are true then output the log we mark an AND check with two ampersands like so  "&&"
        if(thisBoolIsTrue == true && thisBoolIsTrueAlso == true)
        {

            Debug.Log(" Both Bools are True");

        }

        //*** if at least 1 boolean is true then output the log, we mark an OR check with two " pipes" like so "||"
        if(thisBoolIsTrue == true || thisBoolIsTrue == true)
        {

            Debug.Log(" At least 1 Boolean is true True");
        }
    }


    public void TestOutPutVectorValues()
    {

        Debug.Log(" Example vector 2 X valuee == " + exampleVector2.x.ToString() + ", Example Vector Y == " + exampleVector2.y.ToString() + "full vector == " + exampleVector2.ToString());


    }

    public void DisplayExampleSwitchStatement()
    {

        switch (multipleChoiceTestAnswer)
        {

            case 'A':

                Debug.Log(" Multiple choice value == A !");
                break;

            case 'B':

                Debug.Log(" Multiple choice value == B !");
                break;


            case 'C':

                Debug.Log(" Multiple choice value == C !");
                break;


            case 'D':

                Debug.Log(" Multiple choice value == D !");
                break;


            default:
                Debug.Log(" Multiple choice value NOT FOUND CHECK VALUE OR LETTER CASING !");
                break;
        }

    }
}
