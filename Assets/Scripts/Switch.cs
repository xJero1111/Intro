using UnityEngine;

public class Switch : MonoBehaviour
{
    public int ClassSelection = 2;

    void Start()
    {
        string className;

        switch (ClassSelection) 
        {
            case 1:
                className = "Warrior";
                break;
            case 2:
                className = "Wizard";
                break; 
            case 3:
                className = "Archer";
                break;     
            default:
                className = "Invalid Class";
                break;                                          
        }


        Debug.Log("You selected the class: " + className);
    }

    void Update()
    {
        
    }
}