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
        SavePoints(); // resetowanie punktów na początku rozgrywki
    }

    public void IncrementPoints()// automatyczna inkrementacja ilości punktów
    {
        Points++; // zwiększanie punktów
        RefreshText(); // wywołanie funkcji odświeżającej
        SavePoints(); // zapisanie punktów
    }

    public void RefreshText()// odświeżanie tekstu
    {
        GetComponent<Text>().text = Points.ToString() + " points";// pobranie komponentu renderującego tekst
    }

    void SavePoints()// zapisywanie zdobytych punktów na koniec rozgrywki
    {
        PlayerPrefs.SetInt("current_points", Points);
    }
}
