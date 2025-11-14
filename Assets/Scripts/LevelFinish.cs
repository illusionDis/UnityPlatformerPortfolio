using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinish : MonoBehaviour
{
    private GameManager gameManager; // GameManager'i bulmak icin

    [System.Obsolete]
    void Start()
    {
        // GameManager'i bul ve ata
        gameManager = FindFirstObjectByType<GameManager>();
    }

    // Bitis cizgisi bir 'Trigger' olduðu icin bu fonksiyon calisir
    void OnTriggerEnter2D(Collider2D other)
    {
        // Dokunan "Player" mi diye kontrol et
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.ShowWinScreen();// Kazanma ekranini goster

            // Oyuncu kazaninca yurumeye devam etmesin
            // Player'in 'PlayerController' script'ini bul ve devre disi birak
            other.gameObject.GetComponent<PlayerController>().enabled = false;
        }
    }
}