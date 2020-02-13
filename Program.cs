public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    // This all happens once at the beginning of the run


        //Moving these variables to GLOBAL SCOPE (just like JS) so they can be accessed
        //in our void UPDATE to take users guess
        
        //Setting our min and max as variables
        int max = 1000;
        int min = 1;
        //Creating new variable as the player's "guess" (hardcoded for now)
        int guess = 500;
    
    void Start()
    {

        //Printing to the console with our variables
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        //Checking if someone pushed a key down, and if so, write to the console
        //GetKeyDown is for every key, and KeyCode designates which key was pressed
        //End all Debug.Logs with a ;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            //Now these variables work, and we can Debug.Log our guess (hard coded for now)
            //out to the console
            min = guess;
            //Saying our guess is the maximum and the minimum divided by 2 (this would
            //round down for the number) for example 1000 + 1 / 2 = 500 for us
            guess = (max + min) / 2;
            Debug.Log(guess)
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            //Same as min, but using max to check other potential input (up or down)
            max = guess;
            //Same as in the if statement to calculate the guess
            guess = (max + min) / 2;
            Debug.Log(guess)
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }
    }
}

//NOTE at this point there is a bug were you cannot guess 1000 as it only lets you go to 999