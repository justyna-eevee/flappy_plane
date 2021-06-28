using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject[] TerrainBlocks;  // miejsce na wszystkie poziomy

    private int BlockIndex = 0; // funkcja generująca od 0 do nieskończoności 
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GenerateBlock();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenerateBlock()// funkcja odpowiedzialna za umieszczanie jednego losowego bloku  
    {
        var prefab = TerrainBlocks[0]; // losowy element
        var block = Instantiate(prefab); // instancja prefabu
        // umieszczenie bloku na jednej pozycji
        block.transform.position = Vector2.right * BlockIndex * 8f; ; // ustawianie prefaba na odpowiedniej pozycji
        BlockIndex++; 
    }
}
