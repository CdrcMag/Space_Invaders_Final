using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone_Hit : MonoBehaviour
{
    public Variables var;

    public GameObject earth1;
    public GameObject earth2;
    public GameObject earth3;
    public GameObject earth4;

    public ParticleSystem EarthDeath;

    private AudioSource _audioSource;
    public AudioClip EarthDeathSound;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ennemy"))
        {
            //Animation Game Over
            GameOverAnimation();
            
        }
    }

    void GameOverAnimation()
    {
        //freeze tous les ennemis et le joueur
        var.isRunning = false;
        StartCoroutine(DestroyingWorlds());
        

    }


    IEnumerator DestroyingWorlds()
    {
        float time = 0.1f;
        float interval = 1f;

        ParticleSystem exp = Instantiate(EarthDeath, earth1.transform.position, Quaternion.identity);
        Destroy(exp, 0.5f);
        _audioSource.PlayOneShot(EarthDeathSound);
        yield return new WaitForSeconds(time);
        Destroy(earth1);
        yield return new WaitForSeconds(interval);

        ParticleSystem exp1 = Instantiate(EarthDeath, earth2.transform.position, Quaternion.identity);
        Destroy(exp, 0.5f);
        _audioSource.PlayOneShot(EarthDeathSound);
        yield return new WaitForSeconds(time);
        Destroy(earth2);
        yield return new WaitForSeconds(interval);

        ParticleSystem exp2 = Instantiate(EarthDeath, earth3.transform.position, Quaternion.identity);
        Destroy(exp, 0.5f);
        _audioSource.PlayOneShot(EarthDeathSound);
        yield return new WaitForSeconds(time);
        Destroy(earth3);
        yield return new WaitForSeconds(interval);

        ParticleSystem exp3 = Instantiate(EarthDeath, earth4.transform.position, Quaternion.identity);
        Destroy(exp, 0.5f);
        _audioSource.PlayOneShot(EarthDeathSound);
        yield return new WaitForSeconds(time);
        Destroy(earth4);
        yield return new WaitForSeconds(interval);

        SceneManager.LoadScene("GameOver");

    }
}
