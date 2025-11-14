using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject winTextObject; // You win metnini iceren oyun objesi

    public TextMeshProUGUI scoreTextElement; // Skoru ekranda gosterecek TextMeshPro oðesi

    private int score = 0; // Mevcut skoru tutan deðisken

    // Bu fonksiyonu coin'den caðiracaðiz
    public void AddScore(int amount)
    {
        // Skoru 'amount' kadar artir
        score = score + amount;

        // Ekrana skoru yazdir
        scoreTextElement.text = "Skor: " + score.ToString();
    }


    void Start()
    {
        scoreTextElement.text = "Skor: " + score.ToString();// Baslangicta skoru ekranda goster

        winTextObject.SetActive(false); // You win metnini baslangicta gizle
    }
    public void ShowWinScreen()
    {
        winTextObject.SetActive(true);// You win metnini goster
    }

}