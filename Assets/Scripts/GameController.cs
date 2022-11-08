using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    int minValue = 1;
    int maxValue = 100;
    int predictionValue;
    bool startGame = false;
    bool finishGame = false;

    void Start()
    {
        Debug.Log("Merhaba benimle bir oyun oynamak ister misin? (E / H )");
    }

    
    void Update()
    {
        if (!startGame)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Harika! Akl�ndan bir say� tut ve 'Enter' tu�una Bas");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                Debug.Log("Sen bilirsin.");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Value();
                startGame = true;
            }
        }
        else if (!finishGame)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minValue = predictionValue;
                Value();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxValue = predictionValue;
                Value();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Tuttu�un sayiyi buldum");
                finishGame = true;
            }
        }
    }
    void Value()
    {
        predictionValue = (minValue + maxValue) / 2;
        Debug.Log("Tuttu�un say�: " + predictionValue + " m�? Daha b�y�k ise Yukar� Ok tu�u, daha k���k ise A�a�� Ok tu�u, do�ru ise Space tu�una bas.");
    }
}
