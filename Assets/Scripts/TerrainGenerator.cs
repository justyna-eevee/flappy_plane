using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject[] TerrainBlocks;  // miejsce na wszystkie poziomy

    public GameObject InitialBlock; // pole przechowujące blok podstawowy

    private List<GameObject> CurrentBlocks = new List<GameObject>(); // lista bloków znajdujących sie aktualnie na planszy

    private int BlockIndex = 0; // funkcja generująca od 0 do nieskończoności 
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GenerateBlock();
        }
    }

    void GenerateBlock()// funkcja odpowiedzialna za umieszczanie jednego losowego bloku  
    {
        var index = Random.Range(0, TerrainBlocks.Length); // losowanie randomowego indeksu dla poziomu
        var prefab = TerrainBlocks[index]; // losowy element

        if (BlockIndex < 1) // Generowanie pustej planszy na początku gry
        {
            prefab = InitialBlock; 
        }

        var block = Instantiate(prefab); // instancja prefabu
        CurrentBlocks.Add(block);// umieszczenie bloku do listy

        // umieszczenie bloku na jednej pozycji
        block.transform.position = Vector2.right * BlockIndex * 8f; ; // ustawianie prefaba na odpowiedniej pozycji

        // aktualizowanie położenia komponentu kolizji
        GetComponent<BoxCollider2D>().transform.position = Vector2.right * (BlockIndex - 2) * 8f;
            // szukanie komponentu kolizji i ustawianie odpowiednie położenie komponentu

        BlockIndex++; 
    } 

    private void OnTriggerEnter2D(Collider2D position)// obsługa dotknięcia elementu kolizji
    {
        GenerateBlock(); // wywołanie funkcji generującej nowe plansze
        var block = CurrentBlocks.First(); //pobieranie pierwszego elementu z bloku
        Destroy(block); // usuwanie poprzedniego 
        CurrentBlocks.RemoveAt(0); // usuwanie poprzedniego bloku z tablicy
    }
}
