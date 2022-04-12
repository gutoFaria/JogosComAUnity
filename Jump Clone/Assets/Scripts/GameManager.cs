using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;
    public Text txtScore;

    public GameObject bola;
    public GameObject panel;
    public GameObject panelRestart;
    // Start is called before the first frame update
    void Start()
    {
        bola.SetActive(false);
        panel.SetActive(true);
        panelRestart.SetActive(false);
        this.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameScore(int ringScore)
    {
        score += ringScore;
        txtScore.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        panelRestart.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        bola.SetActive(true);
        panel.SetActive(false);
    }
}
