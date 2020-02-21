using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    // This all happens once at the beginning of the run


        //Moving these variables to GLOBAL SCOPE (just like JS) so they can be accessed
        //in our void UPDATE to take users guess
        
        //Setting our min and max as variables

        //Serializing the field here allows for gamplay input for different amounts
        //to be guessed. No longer requires the hard coding.
        [SerializeField] int max
        [SerializeField] int min
        //Now we are using all of our collections, including TextMeshPro
        //It would usually just be a normal text box, but since we are
        //using text mesh pro on our button and input, it is looking for
        //specifically text mesh pro. Once this is connected on Unity,
        //it'll know that once guessText is used in the program, it knows
        //what is input
        [SerializeField] TextMeshProUGUI guessText;
        //Creating new variable as the player's "guess" (hardcoded for now)
        int guess
    
    //Previous mistake. void Start STILL needs to exist.
    void Start()
    {
        //Now we go to start game through void Start to keep it clean
        StartGame()
    }

    //CREATING A NEW FUNCTION!
    //Think of void like function in JS (will get into more detail later; really means no return value)
    //and otherwise we are naming our functions just as we would in JS
    //This function so far takes in no parameters as of yet but it CAN like in JS
    void StartGame()
    {

        //Now since our serialized int max and min are going to be dynamic (lines 14 and 15),
        //we can actually put our guess value here in the void StartGame()
        //so we have a value to compare to as the game starts! And it is no
        //longer hard coded.
        guess = (max + min) / 2;

        //These values are set in our inspector in the Unity Engine.

        //In our text field, it is looking to display a string, so now we have to
        //convert the guessText to a string so it can display on the GAME START
        guessText.text = guess.ToString();
        
        //We keep our max = max + 1 to stay away from the bug we found last time,
        //but now we are going to take out our hard coded values so we can actually
        //use Unity and player input with the public voids to get our range.
        max = max + 1;
    }


    //We took out our UPDATE void. The reason for this is because we are now
    //working with our scene loader. This allows the player input to be
    //used with the Unity Engine publicly, and therefore the game play can
    //be altered.
    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    
    //Note that this new function is void as well (no return value) with 0 parameters

    void NextGuess()
    {
        guess = (max + min) / 2;
    }

}