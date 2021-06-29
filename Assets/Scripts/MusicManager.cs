using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // Przenoszenie muzyki z sceny menu do głównej
    void Start()
    {
        if (FindObjectsOfType<MusicManager>().Length > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject); 
    }
    // Jeśli zostanie otworzone kilka razy menu to obiekt muzyczny będzie stworzony kilka razy ten if zabezpiecza by był w grze tylko jeden


}
