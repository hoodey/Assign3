using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //GameController Variables
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField input;
    int userGuess = 0;
    int guessCounter = 3;
    int computerGuess;

    // Start is called before the first frame update
    void Start()
    {
       computerGuess = Random.Range(1, 11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Member Functions
    //Function to submit answers
    public void submit()
    {
        if (guessCounter != 0)
        {
            guessCounter--;
            userGuess = int.Parse(input.text);
            if (userGuess != computerGuess)
            {
                if(guessCounter == 0)
                {
                    header.text = "Incorrect, you lose this time. Number: " + computerGuess;
                }
                else
                {
                    header.text = "Incorrect, you have " + guessCounter + " guesses remaining.";
                }
            }
            else
            {
                header.text = "Nice job, you win!";
            }
        }

        else
        { 
            header.text = "You're out of guesses, please reset!";
        }
    }
    //Function to reset game state
    public void reset()
    {
        SceneManager.LoadScene("myScene");
    }
}
