using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


[System.Serializable] // to umożliwia nam serializację obiektów wewnątrz danej klasy
public class Medal // klasa przechowująca medale
{
    public Sprite Image; // grafika wyświetlania na ekranie
    public int MinimumPoints; // minimalna ilość punków w celu uzyskania danego medalu
}

public class GameOverScore : MonoBehaviour
{
    public Text Score; // tekst odpowiedzialny za końcową informacje 
    public Medal[] Medals;  // tablica wszystkich medali
    public Image Medal; // obuiekt wyświetlający grafikę medalu
    public GameObject Record; // obiekt informujący gracza o osiągnięciu rekokrdu

    void Start()
    {
        RefreshPoints();
        RefreshMedal();
        RefreshRecord();

    }

    int GetCurrentPoints() // funkcja pobierająca aktualną ilość punktów
    {
        return PlayerPrefs.GetInt("current_points", 0);
    }
    void RefreshPoints() // funkcja aktualizująca aktualną ilość punktów
    {
        var points =  // wyciągnięcie punktów 
        Score.text = GetCurrentPoints().ToString() + " points"; // wyświetlenie tekstu na końcu gry
    }

    void RefreshMedal()// funkcja aktualizująca aktualny medal
        // aby aktualizować grafikę medalu to potrzebujemy referencji do obiektu, który wyświetla tą grafikę
    {
        var points = GetCurrentPoints(); // pobranie aktualnej ilości punktów

        Medal.sprite = Medals // rozpoczęcie anallizy związanej z medalami
            .Where(medal => medal.MinimumPoints <= points) //wybranie tylko tych medali, które mógł zdobyć gracz
            .OrderBy(medal => medal.MinimumPoints) // posortowanie medali od najłatwiejszych do zdobycia do najtrudniejszych
            .Last() // wybieramy ostatni medal czyl ten o najwyższy progu punktowym
            .Image; // wymieramy z naszego obiektu Medal właściwość związaną z obrazkiem

    }
   void RefreshRecord() // funkcja sterująca obiektem rekordu i analiza aktualnej ilości punktów
    {
        var currentPoints = GetCurrentPoints(); // pobranie aktualnej ilości punktów
        var recordPoints = PlayerPrefs.GetInt("record_points", 0); //pobieranie ilości punktów przypisanych do aktualnego rekordu
        bool isRecord = currentPoints > recordPoints; // zmienna sprawdzająca czy jest rekord

        if (isRecord) // jeśli aktualna ilość punktów jest większa od ilości punków rekordu
        {
            PlayerPrefs.SetInt("record_points", currentPoints); // to przypiszemy nowy rekord 
        }
        //Record.GetComponent<Renderer>().enabled = isRecord;//  wyświetlamy wynik o rekordzie
        Record.SetActive(isRecord); // aktywowanie obiektu
        Debug.Log(currentPoints.ToString() + "/ " + recordPoints.ToString());
        //PlayerPrefs.DeleteKey("record_points");
    }
}
