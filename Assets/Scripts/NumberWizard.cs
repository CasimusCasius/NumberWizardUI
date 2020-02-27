﻿using System.Collections;
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

        NextGuess();
        max += 1;
    }


    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
    }
    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        
        max = guess -1 ;
        NextGuess();
    }
}