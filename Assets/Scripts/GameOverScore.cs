using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    public Text Score; // tekst odpowiedzialny za końcową informacje 
    void Start()
    {
        var points = PlayerPrefs.GetInt("current_points", 0); // wyciągnięcie punktów 
        Score.text = points.ToString() + " points"; // wyświetlenie tekstu na końcu gry
    }
}
