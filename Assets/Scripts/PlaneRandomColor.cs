using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// losowa zmiana kolory samolotu, jego animacji
public class PlaneRandomColor : MonoBehaviour
{
    public string[] Animations; // tablica umożliwiająca sprawdzenia zadeklarowanych annimacji
    void Start()
    {
        var index = Random.Range(0, Animations.Length);
        GetComponent<Animator>().Play(Animations[index]); // szukanie i uruchamiania losowej animacji 
    }

}
