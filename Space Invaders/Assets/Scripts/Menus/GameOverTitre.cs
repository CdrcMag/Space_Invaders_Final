using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverTitre : MonoBehaviour
{
    public TextMeshProUGUI Titre;

    private float timer = 0f;
    private float waitingTime = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        Titre.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            Titre.enabled = false;
        }
        if(timer > waitingTime*2)
        {
            Titre.enabled = true;
            timer = 0f;
        }
        
    }
}
