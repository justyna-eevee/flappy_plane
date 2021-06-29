using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// skrypt odpowiedzialny za przesuwanie samolotu
// samolot zawsze będzie zwrócony w prawą stronę i  w prawą stronę będzie się poruszał 
// kąt samolotu będzie się zmieniał w czasie a wartość tego kąta będzie oscylowała pomiędzy dwoma wartościami
// wartość minimalna będzie określała kąt spadania 
// wartość maksymalna będzie określała kąt wznoszenia 
public class PlaneMovement : MonoBehaviour
{
    public float FlyingAngle = 60f;  // wartość odpowiedzialna za wznoszenie
    public float FallgAngle = -80f; // wartość odpowiedzialna za spadanie
    public float CurrentAngle = 0; // zmienna odpowiedzialna za aktualny stan samolotu czyli aktualny kąt poruszania się
    public float Speed = 2f; // szybkość samolotu

    void Update() // chcemy w tej funkcji wybierać aktualny kąt oraz go edytować
    {
        // przyciskiem wyzwalania będzie spacja
        // jeśli użytkownik wciśnię spacje to nasz kąt będzie równy kątowi wzlotu
        // w przeciwnym razie będzie to kąt opadania 
        var targetAngle = Input.GetKey(KeyCode.Space) ? FlyingAngle : FallgAngle;
        CurrentAngle = Mathf.Lerp(CurrentAngle, targetAngle, Time.deltaTime * 2f);// interpolacja aktualneggo kąta poruszania się oraz docelowego
        // dzięki temu uzyskamy płynny ruch samolotu, zaczynamy od kąta aktualnego, następnie kąt do którego zmierzamy,
        // trzecim argumentem jest szybkość z jaką zmierzamy do kąta docelowego i to mnożymy razy aktualny czas
        transform.rotation = Quaternion.Euler(Vector3.forward * CurrentAngle); // ustawienie aktualnego kątu naszego obrotu 
        // transform jes z automatu przypisane do samolotu  w momenciu przypisania skrypty do obiektu
        // wektor ten ma wartość 0 w osi z, 
        transform.Translate(Vector3.right * Speed * Time.deltaTime);// wprowadzenie ruchu samolotem, funkcja ta przesuwa obiekt w zadanym kierunku uwzględniając obrut
        // samolot będzie poruszał się w prawo uwzględniając obrut dlatego nadamy wartość wektora trójwymiarowego w prawo
        // wartość wektora będzie odpowiadała szybkości samolotu
        // funkcja ta wykonuje się co klatkę dlatego samolot będzie poruszać się bardzo szybko, aby znormalizować szybokość ruchu
        // należy pomnożyć wektor razy Time.deltaTime

        
        if (transform.position.y > 2f)
        // pobieranie aktualnej pozycji samolotu
        // wyciągnięcie komponentu y (związanego z wysokością) z pozycji samolotu
        // sprawdzenie czy wyskość nie jest zbyt duża
        {
            SceneManager.LoadScene("GameoverScene"); // jeśli jest to kończymy grę
        }

    }
}
