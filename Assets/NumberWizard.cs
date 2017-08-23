using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;
    int remainingGuesses = 7;

    public Text text;

    // Use this for initialization
    void Start () {
        StartGame();                
    }

    void StartGame () {
        max = 1000;
        min = 1;
        guess = Random.Range(350, 650);
        text.text = guess.ToString();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    void NextGuess() {
        /// Determine the next guess
        guess = Random.Range(min, max+1);

        /// Write next guess to the screen
        text.text = guess.ToString();

        /// See how many guesses are left and decide if player has won
        remainingGuesses = remainingGuesses - 1;
        if (remainingGuesses <= 0)
        {
            SceneManager.LoadScene("Win");
        }

    }

}
