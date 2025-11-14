using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int coinValue = 1; // Bu coin'in kac puan vereceði

    private GameManager gameManager; // GameManager script'ini tutmak icin deðisken

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();// GameManager script'ini bul ve deðiskene ata
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Eðer Player carptiysa:

            // 1. GameManager'daki AddScore fonksiyonunu caðir ve 1 puan ekle.
            gameManager.AddScore(coinValue);

            // 2. Coin'i yok et.
            Destroy(gameObject);
        }
    }
}