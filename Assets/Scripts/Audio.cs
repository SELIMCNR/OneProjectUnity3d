using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("sesBasla", 2.0f); // ýnvoke : metod çalýþtýrýr belli sürede
        Invoke("sesKapat", 8.0f);
    }

 
    void sesBasla()
    {
        audioSource.Play();
    }
    void sesKapat()
    {
        audioSource.Stop();
    }
}
