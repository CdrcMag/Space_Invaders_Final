using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class App_Menu : MonoBehaviour
{
    public GameObject BoutonJouer;
    public SelectedTroughKeyboard sc;
    public bool isSelected = false;
    public AudioSource _audioSource;
    public AudioClip clip;


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
        EventSystem.current.SetSelectedGameObject(BoutonJouer);
        _audioSource = GetComponent<AudioSource>();
        sc.Jouertext.text = "> Jouer <";
        isSelected = true;
    }

    public void Update()
    {
        
    }

    IEnumerator Wait()
    {
        _audioSource.PlayOneShot(clip);
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Main");
    }
    








}
