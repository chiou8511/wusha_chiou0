using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScene : MonoBehaviour
{
    public Button switchSceneButton; // 拖入你的按鈕
    public string targetSceneName;   // 要切換到的場景名稱

    void Start()
    {
        if (switchSceneButton != null)
        {
            // 為按鈕添加點擊事件
            switchSceneButton.onClick.AddListener(SwitchScene);
        }
        else
        {
            Debug.LogError("請指定按鈕！");
        }

        if (string.IsNullOrEmpty(targetSceneName))
        {
            Debug.LogError("請設置目標場景名稱！");
        }
    }

    void SwitchScene()
    {
        if (!string.IsNullOrEmpty(targetSceneName))
        {
            SceneManager.LoadScene(targetSceneName);
        }
        else
        {
            Debug.LogError("目標場景名稱無效！");
        }
    }
}
