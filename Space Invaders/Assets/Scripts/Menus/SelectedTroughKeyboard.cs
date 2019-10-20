using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class SelectedTroughKeyboard : MonoBehaviour
{
    public string key;
    public TextMeshProUGUI Jouertext;
    public TextMeshProUGUI Quittertext;
    public App_Menu app_menu;
    public AudioSource audioSource;
    public AudioClip switchingSound;
    public AudioClip SelectedSound;

    private string temp1;
    private string temp2;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        temp1 = "Jouer";
        temp2 = "Quitter";
    }



    public void Update()
    {
        if (Input.GetKeyDown(key))
        {
            EventSystem.current.SetSelectedGameObject(this.gameObject);
            audioSource.PlayOneShot(switchingSound);

            if (key == "q")
            {
                Jouertext.text = "> " + temp1 + " <";
                Quittertext.text = temp2;
                
            }

            if (key == "d")
            {
                Jouertext.text = temp1;
                Quittertext.text = "> " + temp2 + " <";
            }
        }
        
    }


    
    
}
