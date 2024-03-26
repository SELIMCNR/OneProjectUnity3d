using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{
    AudioSource Sesler;
public    AudioClip Alkis, GameOver;

    // Start is called before the first frame update
    void Start()
    {
        Sesler = gameObject.GetComponent<AudioSource>();
        Invoke("alkisSes", 2.0f); // beklet ve fonksiyon baþlat
        Invoke("gameOverSes", 6.0f);
        
    }

    void alkisSes()
    {
        //ilk ses
        Sesler.PlayOneShot(Alkis);
    }
    void gameOverSes()
    {
        //son ses
        Sesler.PlayOneShot(GameOver);
    }
}
