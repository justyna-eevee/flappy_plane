using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// skrypt odpowiedzialny za kolizje zdarzeń

public class GameoverWhenHit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // funkcja wywołująca się automatycznie w momencie zdarzenia, kiedy samolot wejdzie w obszar wyzwalania
    {
        //po wywołaniu tej metody chcemy się przenieść do sceny związanej z końcem gry
        SceneManager.LoadScene("GameoverScene"); // podanie nazwy sceny
    }
}

