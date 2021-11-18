using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Collider2D playerCol;
    [SerializeField] TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText.text = "0/25";
    }

    
}
