using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    public int min = 1;
    public int max = 1000;
    int guess;

    public Text title;
    
    void Start()
    {
        //min = 1;
        //max = 1000;
        title.text = "Magic Numbers";
        print("Загадайте число от  " + min + "до" + max);
        UpdateGuess();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            print("the end");
            Start();
        }
    }
    void UpdateGuess()
    {
        {
            guess = (min + max) / 2;
            print("Ваше число:" + guess + "?");
        }
    }
}

