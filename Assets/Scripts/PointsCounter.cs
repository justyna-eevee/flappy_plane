using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    int Points = 0;// zmienna przechowująca aktualną ilość punktów
    void Start()
    {
        RefreshText(); // załadowanie na początku gry liczby punktów
    }

    public void IncrementPoints()// automatyczna inkrementacja ilości punktów
    {
        Points++; // zwiększanie punktó
        RefreshText(); // wywołanie funkcji odświeżającej
    }

    public void RefreshText()// odświeżanie tekstu
    {
        GetComponent<Text>().text = Points.ToString() + " points";// pobranie komponentu renderującego tekst
    }

}
