using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOne : MonoBehaviour
{

    int x = 5;
    int y = 15;
    string yazi = "a";
    // Start is called before the first frame update
    public string[] isimler;
    public float[] sayilar;
    public int donmeHizi = 4;
    public float hiz = 0.1f;

    public List<float> Sayilar;
    void Start()
    {
        isimler = new string[4];
        isimler[0] = "A";
        isimler[1] = "B";
        isimler[0] = null;

        Debug.Log(isimler[0]);
        Debug.Log(isimler[1]);

        if (x > y)
        {
            x = y;
        }
        else if (x < y)
        {
            y = x;
            float x1 = 1.5f;
            float y2 = 1.4f;
            Parameterli(x1, y2);
        }
        else
        {
            x = 10;
            Parametersiz();
        }
        string ad = "a";
        string soyad = "b";
        Debug.Log(toplam(x, y));
        Debug.Log(adSoyad(ad, soyad));
        x++;
        x--;
        x *= y;
        x /= y;
        x *= y++;
        x /= --x;
        ++x;

        for(int i = 0;i< x; ++i)
        {
            Debug.Log(i);
        }

        while(x < y)
        {
            y++;
            Debug.Log(y);
        }
        sayilar = new float[10];
        for(int i = 0;i< 10; i++)
        {
            sayilar[i] = Random.Range(0.0f, 100.0f);
            Debug.Log(i);
        }
        
        Sayilar =new List<float>() { 5.5f,7.8f};
        Sayilar.Add(12.5f);
        Sayilar.Add(1.1f);
        Debug.Log("Ýlk sayý : " + Sayilar[1]);
        Debug.Log(Sayilar.Count);
        Sayilar.RemoveAt(2); // 2.indisi sil
        Sayilar.Remove(5.5f); //SEÇÝLÝ SAYIYI SÝLER
        Sayilar.Clear();  // HEPSÝNÝ SÝLER


        sayilar = new float[] { 15.2f,1.2f};
        for(int i =0;i< 10; i++)
        {
            Debug.Log(sayilar[i]);  
        }

        foreach(int i in sayilar)
        {
            Debug.Log(sayilar[i]);
        }

        List<string> isimler1 = new List<string>() { "a","b"};
        foreach(var  name in isimler1)
        {
            Debug.Log(name);
        }

        degerler("ak", 8);



    }

    void degerler(string yazi,int x)
    { 
        this.yazi = yazi;
        this.x = x;
    
    }

    void Parametersiz()
    {
        Debug.Log("A");
    }
    void Parameterli(float sayi1,float sayi2)
    {
        float deger=sayi1 + sayi2;
        Debug.Log(deger);
    }

    int toplam(int x,int y)
    {
        return x + y;
    }

    string adSoyad(string ad ,string soyad)
    {
        return ad + soyad;
    }

    // Update is called once per frame
    void Update()
    {
        //Kutu hareketi
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(hiz,0f,0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(-hiz,0f,0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up,donmeHizi);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up,-donmeHizi);
        }
    }
}
