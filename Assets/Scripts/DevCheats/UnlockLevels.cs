using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockLevels : MonoBehaviour {

    void Start()
    {
        #if !UNITY_EDITOR
        gameObject.SetActive(false);
        #endif
    }

    public void Button_UnlockAll()
    {
        SaveSwitch.UnlockAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Button_ClearAll()
    {
        SaveSwitch.ClearAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
