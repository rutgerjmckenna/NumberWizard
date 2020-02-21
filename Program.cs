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

        // Now that next guess is creating the same code, in startgame we can
        //have it simply call next guess for a clean refactor

        NextGuess();
        // that max = max + 1 is now redundant and can be deleted!
    }


    //We took out our UPDATE void. The reason for this is because we are now
    //working with our scene loader. This allows the player input to be
    //used with the Unity Engine publicly, and therefore the game play can
    //be altered.
    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }
    //Adding the plus one to min and minus one to max allows us to then
    //have a window that doesn't include the previous number when narrowing
    //down the guesses
    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    
    //Note that this new function is void as well (no return value) with 0 parameters

    void NextGuess()
    {
        //Now we get a random value between min and max!
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

}