using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundManagement : MonoBehaviour
{
    public AudioClip shoot;
    public AudioClip hit;
    public AudioClip death;
    public AudioSource audioSource;
    public Variables var;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (var.isShooting == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                audioSource.PlayOneShot(shoot);
            }
        }
    }
}
