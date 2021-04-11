using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class zeminmanager : MonoBehaviour
{
    public Transform sise;
    int can;
    public TextMeshProUGUI cantext,sonuctext;
    public AudioSource audioSource;
    public AudioClip kırma;

    // Start is called before the first frame update
    void Start()
    {
        
        can = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        cantext.text = "Can : " + can.ToString();
        if (can == 0)
        {
            sonuctext.text = "Oyun Bitti Tekrar Oynamak İcin Bir Tusa Bas";
            Time.timeScale = 0f;
            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene("SampleScene");
                Time.timeScale = 1f;
              
            }
        }
    }
    private void OnCollisionEnter(Collision temas)
    {
        float rast = Random.Range(-6f, 6f);
        if (temas.gameObject.tag == "sise")
        {

            sise.position = new Vector3(rast, 6f, 0f);
            can--;
            audioSource.PlayOneShot(kırma);

        }
    }
}
