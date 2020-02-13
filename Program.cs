public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    // This all happens once at the beginning of the run


        //Moving these variables to GLOBAL SCOPE (just like JS) so they can be accessed
        //in our void UPDATE to take users guess
        
        //Setting our min and max as variables
        int max
        int min
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

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Checking if someone pushed a key down, and if so, write to the console
        //GetKeyDown is for every key, and KeyCode designates which key was pressed
        //End all Debug.Logs with a ;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            //Now that we have created a NextGuess void function (see below) we can just
            //call our update to utilize that function to organize our code and keep
            //it clean and organized
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            //Same as in the if statement
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I CAN READ YOUR MINDDDDDD");
            //Can restart game
            StartGame();
        }
    }
    
    //Note that this new function is void as well (no return value) with 0 parameters

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess + "?");
    }

}