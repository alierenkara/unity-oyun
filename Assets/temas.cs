using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temas : MonoBehaviour {

    private void OnCollisionEnter(Collision durum)
    {
        //if (durum.gameObject.name == "zemin")
        if (durum.gameObject.tag=="Player")
        {
            Debug.Log("DEGDİ");
        }
    }
}
