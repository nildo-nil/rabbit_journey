using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public GameObject loseUI;
    
    public void ShowLoseUI()
    {
        if(loseUI != null)
        {
            loseUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void MainButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
}
