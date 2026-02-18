using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject gamePanel;
    public GameObject creditsPanel;

    public void OpenGame(){
        menuPanel.SetActive(false);
        creditsPanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    public void OpenMenu(){
        menuPanel.SetActive(true);
        creditsPanel.SetActive(false);
        gamePanel.SetActive(false);
    }

    public void OpenCredits(){
        menuPanel.SetActive(false);
        gamePanel.SetActive(false);
        creditsPanel.SetActive(true);
    }
    
}
