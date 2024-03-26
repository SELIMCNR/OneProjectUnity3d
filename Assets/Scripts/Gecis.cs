using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gecis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision temas)
    {
        //Level Geçiþi
       if(temas.gameObject.name == "Silindir")
        {
           
            SceneManager.LoadScene("Sahne2");
        }            
    }
}
