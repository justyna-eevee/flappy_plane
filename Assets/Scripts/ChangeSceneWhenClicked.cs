using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWhenClicked : MonoBehaviour
{
    public string SceneName; // zmienna przechowująca nazwę sceny do której będziemy przechdzić 

    private void OnMouseDown() //funkcja uruchamiana w momencie naciśnięcia na ekran
    {
        SceneManager.LoadScene(SceneName);
    }
}
