using System.Globalization;
using UnityEngine;

public class script : MonoBehaviour
{
    [SerializeField] string myName;
    [SerializeField] int myNumber;
    [SerializeField] bool myChoice;
    int myOtherNumber;
    [SerializeField] GameObject myGate;
    
    



       void Start()
    {
        myNumber = 9;
        myChoice = true; 


         
        
    
        
       
    
    }

    
    void Update()
    {
              if(myNumber == 4 && myChoice == true)
        {
          myName = "Phillip";
          myGate.SetActive(true);
        }

        else
        {
            myName = "Fred";
            myGate.SetActive(false);
        }  
    }
}
