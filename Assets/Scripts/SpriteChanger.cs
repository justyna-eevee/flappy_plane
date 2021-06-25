using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Będzie wykonywany kod odpowiedzialny za animację obrazka
// chcemy aby animacja trwała cały czas aż gra się nie zakończy
public class SpriteChanger : MonoBehaviour
{
    public Sprite[] Sprites; //tablica na grafiki do animacji obrazka
    public float Duration = 1f; //czas zmian grafiki 1 sekunda

    void Start()
    {
        StartCoroutine(ChangeSpriteCoroutine()); // uruchomienie korutyny
    }

    IEnumerator ChangeSpriteCoroutine()
    {
        var render = GetComponent<SpriteRenderer>(); // szukanie komponentu renderującego spritey

        for (int i = 0; true; i++) // nnieskończona pętna
        {
            render.sprite = Sprites[i % Sprites.Length]; // przypisanie nowej wartości
            yield return new WaitForSeconds(Duration); // wstrzymanie czasu
        }
    }
}
