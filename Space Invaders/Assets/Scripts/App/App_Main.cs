using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class App_Main : MonoBehaviour
{
    public AudioSource audioSource;
    public Variables var;

    public GameObject EnnemyArmy;
    public GameObject placementArmy;
    public Score score;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    public void Update()
    {
        if(var.ennemyCount == 0)
        {
            StartCoroutine(Wait());
            var.ennemyCount = 36;
            var.fallTime -= 0.5f;
            
        }
    }

    public void PlayDeathSound()
    {
        audioSource.Play();
    }
    
    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        Instantiate(EnnemyArmy, placementArmy.transform.position, Quaternion.identity);
        
    }
}
