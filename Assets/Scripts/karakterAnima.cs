using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterAnima : MonoBehaviour
{

    Animator animasyon;
    int yuruyor, zýplýyor;
    // Start is called before the first frame update
    void Start()
    {
        animasyon = GetComponent<Animator>();

        yuruyor = Animator.StringToHash("yurume");
        zýplýyor = Animator.StringToHash("zýplama");
    }

    // Update is called once per frame
    void Update()
    {
        bool yurume = animasyon.GetBool(yuruyor);
        bool zýplama = animasyon.GetBool(zýplýyor);
        bool yurumeBasla = Input.GetKey("w");
        bool zýplamaBasla = Input.GetKey("space");

    

        if (!yurume && yurumeBasla)
        {
            animasyon.SetBool(yuruyor, true);
        }
        if (yurume && !yurumeBasla)
        {
            animasyon.SetBool(yuruyor, false);
        }
        if (!zýplama && zýplamaBasla)
        {
            animasyon.SetBool(zýplýyor, true);
        }
        if (zýplama && !zýplamaBasla)
        {
            animasyon.SetBool(zýplýyor, false);
        }

    }
}
