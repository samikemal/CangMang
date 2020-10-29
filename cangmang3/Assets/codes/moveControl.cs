using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class moveControl : MonoBehaviour
{
    public Rigidbody2D rb;
    bool yereDegiyor = false;
    bool usteDegiyor = false;
    bool gravity = true;
    public float ziplamaKuvvet;
    float score=0;
    public Text scoreText;
    public GameObject oyuncu;
    public GameObject menu;
    public GameObject winMenu;
    

    void Start()
    {
        Physics2D.gravity = new Vector2(0, -39.24f); // fizik motorunun gravity değerini güncelledik    
        rb = oyuncu.GetComponent<Rigidbody2D>();
        AudioListener.pause = false; // oyunla birlikte müzik de direk başlıyor
        winMenu.SetActive(false); // kazanma pop-up'ı oyun bitinceye kadar gizli kalacak

    }

    void FixedUpdate() // fizik ile ilintili mekanikleri daha iyi gösterebilmek için update yerine fixedupdate metodu kullanıldı
    {

        rb.velocity = new Vector2(5, rb.velocity.y); //karaktere sabit hız verildi

    

        if (Input.GetKey(KeyCode.Space)) // oyuncu space tuşuna basınca çalışacak mekanikler
        {
            if (gravity && yereDegiyor)
            {
                rb.velocity = new Vector2(rb.velocity.x, 10);
            }
            else if (!gravity && usteDegiyor)
            {
                rb.velocity = new Vector2(rb.velocity.x, -10);
            }
        }
        score += Time.deltaTime; // saniyeye bağlı olarak skorumuz artıyor

        scoreText.text = "SCORE : " + Mathf.RoundToInt(score); // skor ekrana basılıyor
    }
    void OnCollisionEnter2D(Collision2D col) // karakter ile nesnelerin etiketleri üzerinden etkileşimleri bu fonksiyonda başlatılıyor
    {

      

        if (gravity && (col.gameObject.tag == "zemin" || col.gameObject.tag == "sutun"))
        {
            yereDegiyor = true;
        }
        else if (!gravity && (col.gameObject.tag == "ustzemin" || col.gameObject.tag == "sutun"))
        {
            usteDegiyor = true;
        }
        if (col.gameObject.tag == "win")
        {
            AudioListener.pause = true;
            winMenu.SetActive(true);
        }
     
    }
    void OnCollisionStay2D(Collision2D col) // karakter ile nesne etkileşimi boyunca çalışacak fonksiyondur
    {
        if (gravity && (col.gameObject.tag == "zemin" || col.gameObject.tag == "sutun"))
        {
            yereDegiyor = true;
        }
        else if (!gravity && (col.gameObject.tag == "ustzemin" || col.gameObject.tag == "sutun"))
        {
            usteDegiyor = true;
        }
    }
    void OnCollisionExit2D(Collision2D col) // karakter ile nesnelerin etkileşimi bittiği zaman çalışacak fonksiyondur
    {
        if (gravity && (col.gameObject.tag == "zemin" || col.gameObject.tag == "sutun"))
        {
            yereDegiyor = false;
        }
        else if (!gravity && (col.gameObject.tag == "ustzemin" || col.gameObject.tag == "sutun"))
        {
            usteDegiyor = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision) // bazı nesneler trigger olarak tanımlanmıştır ve bu tanımlanmanın sonucun o nesnelerle etkileşime başladığında çalışacak fonksiyondur
    {

        if (collision.gameObject.tag == "yanma" || collision.gameObject.tag == "sutunYanma")
        {
            Destroy(oyuncu);
            menu.SetActive(true);
        }

        if (gravity && collision.gameObject.tag == "powerup")
        {
            yereDegiyor = true;
        }
        else if (!gravity && collision.gameObject.tag == "powerup")
        {
            usteDegiyor = true;
        }
        if (gravity && collision.gameObject.tag == "yenichanger")
        {
          
            if (Input.GetKey(KeyCode.Space))
            {
                Physics2D.gravity = new Vector2(0, 39.24f);
                rb.velocity = new Vector2(rb.velocity.x, 10);
                gravity = false;
            }
        }
        else if (!gravity && collision.gameObject.tag == "yenichanger")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Physics2D.gravity = new Vector2(0, -39.24f);
                rb.velocity = new Vector2(rb.velocity.x, -10);
                gravity = true;
            }
        }

    }

    void OnTriggerExit2D(Collider2D collision) // trigger işaretli nesneler ile karakter arasındaki etkileşimin bittiği anda çalışacak fonksiyondur
    {
        if (gravity && collision.gameObject.tag == "powerup")
        {
            yereDegiyor = false;
        }
        else if(!gravity && collision.gameObject.tag == "powerup")
        {
            usteDegiyor = false;
        }
        if (gravity && collision.gameObject.tag == "yenichanger")
        {
            yereDegiyor = false;
        }
        else if (!gravity && collision.gameObject.tag == "yenichanger")
        {
            usteDegiyor = false;
        }
    }





}