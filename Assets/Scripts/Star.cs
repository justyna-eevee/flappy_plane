using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision) // funkcja uruchamiająca się w momencie zderzenia samolotu z gwiazdką
    {
        GetComponent<AudioSource>().Play(); // szukanie komponentu dźwiękowego i uruchamianie go w momencie zderzenia
        GetComponent<SpriteRenderer>().enabled = false;// szukanie komponentu renderującego i wyłączenie komponentu
        FindObjectOfType<PointsCounter>().IncrementPoints(); // szukanie obiektu, który ma przypisany skrypt PointsCounter a następnie użyć na tym obiekcie funkcji
        Destroy(gameObject, 3f); // usuwanie gwiazdki po ustalonym czasie (przeciążenie)

    }
}
