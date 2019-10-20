using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_OnTriggerEnter2D : MonoBehaviour
{
    public Variables var;
    public GameObject[] lives = new GameObject[3];
    private Rigidbody2D rbPlayer;
    public PlayerSoundManagement _audio;
    private SpriteRenderer sprite;
    public Score scoreScript;
    public App_Main app;
    public ParticleSystem exp;

    public static bool state = true;

    public void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        _audio = GetComponent<PlayerSoundManagement>();
        sprite = GetComponent<SpriteRenderer>();
        scoreScript = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnnemyBullet"))
        {
            Destroy(collision.gameObject);
            _audio.audioSource.PlayOneShot(_audio.hit);
            var.life--;
            if (var.life > 0)
            {
                StartCoroutine(Blinking());
                Destroy(lives[var.life]);
            }

            if (var.life == 0)
            {
                var.isRunning = false;
                Destroy(lives[var.life]);
                ParticleSystem boom = Instantiate(exp, transform.position, Quaternion.identity);
                Destroy(boom, 0.2f);
                StartCoroutine(Death());
                GetComponent<SpriteRenderer>().enabled = false;
                rbPlayer.constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }
    }

    void Blink()
    {
        sprite.enabled = state;
        state = !state;
    }

    IEnumerator Blinking()
    {
        InvokeRepeating("Blink", 0f, 0.15f);
        yield return new WaitForSeconds(0.8f);
        CancelInvoke();
        sprite.enabled = true;
        state = true;
        if (var.life == 0)
        {
            sprite.enabled = false;
            state = false;
        }
    }

    IEnumerator Death()
    {
        _audio.audioSource.PlayOneShot(_audio.death);
        yield return new WaitForSeconds(0.5f);
        app.LoadGameOver();
    }

}
