using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// skrypt przypisany do kamery, który jest odpowiedzialny za podążaniem za ruchem samolota
public class CameraMovement : MonoBehaviour
{
    public Transform TrackedObject; // zmienna odpowiedzialna za aprzypisanie obiektu do śledzenia
    public float Delax;// zmienna śledzona określająca przesunięcie w osi x
    
    void Update()
    {
        transform.position = new Vector3(TrackedObject.position.x + Delax, transform.position.y, transform.position.z);// pozycja kamery
        // wartość w poziomie będzie odczytywana od śledzonego obiektu argument 1
        // argument 2 i 3 aargument będą odczytywane z aktualnego położenia
    }
}
