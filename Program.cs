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


    //CREATING A NEW FUNCTION!
    //Think of void like function in JS (will get into more detail later; really means no return value)
    //and otherwise we are naming our functions just as we would in JS
    //This function so far takes in no parameters as of yet but it CAN like in JS
    void StartGame()
    {
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
            //Now these variables work, and we can Debug.Log our guess (hard coded for now)
            //out to the console
            min = guess;
            //Saying our guess is the maximum and the minimum divided by 2 (this would
            //round down for the number) for example 1000 + 1 / 2 = 500 for us
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than " + guess);
            //Moved the above Debug.Log to this line to enable it to interpolate the
            //guess amount, but due to our SCOPE so it doesn't look globally (and instead
            //within the if statement), we move it lower so our min = guess sets our
            //guess value
            Debug.Log(guess)
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Same as min, but using max to check other potential input (up or down)
            max = guess;
            //Same as in the if statement to calculate the guess
            guess = (max + min) / 2;
            //See comment on line 52
            Debug.Log("Is it higher or lower than " + guess);
            Debug.Log(guess)
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I CAN READ YOUR MINDDDDDD");
        }
    }
}