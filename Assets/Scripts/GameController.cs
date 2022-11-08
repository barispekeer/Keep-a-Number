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
                Debug.Log("Harika! Aklýndan bir sayý tut ve 'Enter' tuþuna Bas");
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
                Debug.Log("Tuttuðun sayiyi buldum");
                finishGame = true;
            }
        }
    }
    void Value()
    {
        predictionValue = (minValue + maxValue) / 2;
        Debug.Log("Tuttuðun sayý: " + predictionValue + " mý? Daha büyük ise Yukarý Ok tuþu, daha küçük ise Aþaðý Ok tuþu, doðru ise Space tuþuna bas.");
    }
}
