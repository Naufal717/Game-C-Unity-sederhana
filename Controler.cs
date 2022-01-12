using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    //variable programing C#
    //..sebagai sarana deklarasi tipe data yang suatu saat bakal di gunakan
    //.. oleh sebab itu variable dengan tipe data string akan di pakai di beberapa syntax yang akan di execusi
    //..write bye Naufal Al Munawar
    string a = "Soekarno";
    string b = "Bj.Habiebie";
    string c = "Jokowi";
    string d = "Soharto";
    bool instan = true;
    string jawaban_BEnar = "jawaban anda benar!!!";
    string jawbanaSalah = "jawaban anda salah";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Siapakah presiden pertama indonesia?... \n A. {a}" + $"\n B. {b}" + $"\n C. {c}" + $"\n D. {d}");
    }

    // Update is called once per frame
    void Update()
    {
        
        jawbanaA(jawaban_BEnar, instan);
        jawabanB(jawbanaSalah, instan);
        jawabanC(jawbanaSalah, instan);
        jawabanD(jawbanaSalah, instan);

    }
    void jawbanaA(string a, bool eden){
        if(Input.GetKeyDown(KeyCode.A) && eden){
                Debug.Log(a);
        }
    }
    void jawabanB(string b, bool eden){
        if(Input.GetKeyDown(KeyCode.B) && eden){
            Debug.Log(b);
        }
    }
    void jawabanC(string c, bool eden){
        if(Input.GetKeyDown(KeyCode.C) && eden){
            Debug.Log(c);
        }
    }
    void jawabanD(string d, bool eden){
        if(Input.GetKeyDown(KeyCode.D) && eden){
            Debug.Log(d);
        }
    }
}
//Copyrigt 2022 - By. Naufal Al Munawar