using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject gamePanel;

    public void OpenGame(){
        menuPanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    public void OpenMenu(){
        menuPanel.SetActive(true);
        gamePanel.SetActive(false);
    }

    
}
