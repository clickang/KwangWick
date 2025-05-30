using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    // float alphaThreshold = 0.1f;
    // private void Start()
    // {
    //     GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;
    // }

    public void ChangeSceneBtn()
    {
        string btnName = this.gameObject.name;

        if (btnName == "Start")
        {
            SceneManager.LoadScene("Gameplay");
        }
        else if (btnName == "Settings")
        {
            GameObject settingsPanel = GameObject.Find("settingsPanel");
            if (settingsPanel != null)
            {
                settingsPanel.SetActive(true);
            }
        }
        else if (btnName == "Exit")
        {
            Application.Quit();
            Debug.Log("게임 종료됨.");
        }
    }
}
