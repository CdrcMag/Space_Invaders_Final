using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class KeyboardControlGameOver : MonoBehaviour
{
    public string key;
    public TextMeshProUGUI RecommencerText;
    public TextMeshProUGUI Quittertext;
    public App_GameOver app_GameOver;
    


    private string temp1;
    private string temp2;

    private void Start()
    {
        temp1 = "Recommencer";
        temp2 = "Quitter";
    }



    public void Update()
    {
        if (Input.GetKeyDown(key))
        {
            EventSystem.current.SetSelectedGameObject(this.gameObject);

            if (key == "q")
            {
                app_GameOver._audioSource.PlayOneShot(app_GameOver.switching);
                RecommencerText.text = "> " + temp1 + " <";
                Quittertext.text = temp2;

            }

            if (key == "d")
            {
                app_GameOver._audioSource.PlayOneShot(app_GameOver.switching);
                RecommencerText.text = temp1;
                Quittertext.text = "> " + temp2 + " <";
            }
        }
    }
}
