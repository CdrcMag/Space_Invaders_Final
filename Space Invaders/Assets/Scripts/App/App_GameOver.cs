using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;

public class App_GameOver : MonoBehaviour
{
    public GameObject BoutonRecommencer;
    public KeyboardControlGameOver sc;
    public bool isSelected = false;
    public AudioSource _audioSource;
    public AudioClip clip;
    public AudioClip switching;
    
    //----//

    public TextMeshProUGUI currentScoreValue;
    public TextMeshProUGUI highScoreValue;


    public void LaunchGame()
    {
        StartCoroutine(Wait());
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Start()
    {
        EventSystem.current.SetSelectedGameObject(BoutonRecommencer);
        _audioSource = GetComponent<AudioSource>();
        sc.RecommencerText.text = "> Recommencer <";
        isSelected = true;

        currentScoreValue.text = PlayerPrefs.GetInt("CurrentScore").ToString();
        highScoreValue.text = PlayerPrefs.GetInt("HighScore").ToString();
        

    }
    


    IEnumerator Wait()
    {
        _audioSource.PlayOneShot(clip);
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Main");
    }
}
