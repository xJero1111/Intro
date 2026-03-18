using UnityEngine;

public class VariablesExamples : MonoBehaviour
{
    //Al declarar las variables como "public" podemos verlas y modificarlas
    public string characterName = "Omega";
    public int healtPoints = 100;
    public float moveSpeed = 5.5f;
    public bool hasDungeounKey = false;


    //Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        Debug.Log("Nombre: " + characterName)

    }

    // Update is called once per frame

    void Update()
    {
        
    }
    
}
