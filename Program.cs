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
        //Added these values here so when we restart the game now, it starts it at
        //1000 and NOT 1001 (from recalling start game). Notice that max, min, and guess
        //are still instantiated starting up on line 11, but just to tell C# what TYPE of
        //data they are (int = integer = number value) and they are now set here :)
        max = 1000;
        min = 1;
        guess = 500;

        max = max + 1;
    }


    //We took out our UPDATE void. The reason for this is because we are now
    //working with our scene loader. This allows the player input to be
    //used with the Unity Engine publicly, and therefore the game play can
    //be altered. After we commit this we will change our hard coded values above
    //as the public void allows us to enter the numeric amounts on Unity.
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
        Debug.Log("Is it higher or lower than " + guess + "?");
    }

}