using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision temas)
    {
        // Obje yok olmasý
        if(temas.gameObject.tag == "kutu")
        {
            Destroy(temas.gameObject);
        }
    }
}
