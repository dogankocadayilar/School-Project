using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject finishMenu;
    [SerializeField] Collider2D player;
    [SerializeField] Collider2D exit;

    public void PlayGame() {SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); Time.timeScale = 1; }
    public void ExitGame() => Application.Quit();
    public void OptionsBack() => Time.timeScale = 1;
    public void OptionsExit() => SceneManager.LoadScene(0);
    public void DeathRestart() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (optionsMenu.activeInHierarchy)
            {
                optionsMenu.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
                optionsMenu.SetActive(true);
            }
        }

        if(player != null)
        {
            if (player.IsTouching(exit))
            {
                finishMenu.SetActive(true);
                player.gameObject.SetActive(false);
            }
        }
    }


}
