using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class boxmanager : MonoBehaviour
{
   public  float movespeed;
    public Transform sise;
    public AudioSource audioSource;
    public AudioClip kırma;
     int puan;
    public TextMeshProUGUI puantext;
    void Update()
    {
        puantext.text = "Puan : " + puan.ToString();
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-movespeed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(movespeed * Time.deltaTime, 0f, 0f);
        }
    }
    private void OnCollisionEnter(Collision temas)
    {
        float rast = Random.Range(-6f, 6f);
        if(temas.gameObject.tag=="sise")
        {
            puan += 5;
            sise.position = new Vector3(rast, 6f, 0f);
            audioSource.Play();
        }
    }
    
}
