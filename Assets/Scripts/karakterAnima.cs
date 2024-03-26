using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterAnima : MonoBehaviour
{

    Animator animasyon;
    int yuruyor, z�pl�yor;
    // Start is called before the first frame update
    void Start()
    {
        animasyon = GetComponent<Animator>();

        yuruyor = Animator.StringToHash("yurume");
        z�pl�yor = Animator.StringToHash("z�plama");
    }

    // Update is called once per frame
    void Update()
    {
        bool yurume = animasyon.GetBool(yuruyor);
        bool z�plama = animasyon.GetBool(z�pl�yor);
        bool yurumeBasla = Input.GetKey("w");
        bool z�plamaBasla = Input.GetKey("space");

    

        if (!yurume && yurumeBasla)
        {
            animasyon.SetBool(yuruyor, true);
        }
        if (yurume && !yurumeBasla)
        {
            animasyon.SetBool(yuruyor, false);
        }
        if (!z�plama && z�plamaBasla)
        {
            animasyon.SetBool(z�pl�yor, true);
        }
        if (z�plama && !z�plamaBasla)
        {
            animasyon.SetBool(z�pl�yor, false);
        }

    }
}
