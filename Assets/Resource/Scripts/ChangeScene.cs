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
        if (this.gameObject.name == "Start") SceneManager.LoadScene("SampleScene");
    }
}
