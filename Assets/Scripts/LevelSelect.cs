using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    TextMeshProUGUI levelNum;

    void Start()
    {
        levelNum = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void StartScene() => SceneManager.LoadScene(int.Parse(levelNum.text));
}
