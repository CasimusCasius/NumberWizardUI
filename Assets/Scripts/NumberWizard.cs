using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min = 1;
    [SerializeField] int max = 1000;

    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        guess = (min + max) / 2;
        guessText.text = guess.ToString();

    }


    void NextGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }
    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        if (guess > 1)
            max = guess - 1;
        else
            max = guess;
        NextGuess();
    }
}