using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyonkod : MonoBehaviour
{
    Animator animasyon;
    // Start is called before the first frame update
    void Start()
    {
        animasyon = gameObject.GetComponent<Animator>();
        Invoke("donmeGec", 5f);
        
    }

    // Update is called once per frame
    void donmeGec()
    {
        animasyon.SetBool("aktiflik", true);
    }
}
