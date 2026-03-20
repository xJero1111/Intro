using UnityEngine;

public class IfElse : MonoBehaviour
{
    public int numberToCheck = 27;

//Start is called once before the first execution of Update after the MonoBehaviour
    void Start()
    {
        if (numberToCheck % 2 == 0)
        {
            Debug.Log ("El numero " + numberToCheck + " es Par");
        }
        else
        {
            Debug.Log ("El numero " + numberToCheck + " es Impar");
        }
    }
}