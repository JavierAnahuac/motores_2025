using UnityEngine;

public class Animal : MonoBehaviour
{
    public int hungerLevel = 5;
    private int _currentHungerLevel;

    private void Start()
    {
        Debug.Log(Eat());
        Debug.Log(Eat());
        Debug.Log(Eat());
        Debug.Log(Eat());
        Debug.Log(Eat());
    }

    private bool Eat()
    {
        _currentHungerLevel++;
        if (_currentHungerLevel >= hungerLevel)
        {
            Debug.Log("Ya me llen�");
            return true;
        }

        Debug.Log("A�n tengo hambre");
        return false;
    }
}
