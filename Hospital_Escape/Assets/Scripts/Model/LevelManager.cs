using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    public LevelModel currentLevelModel;
	void Start () {
        instance = this;
        LoadLevelInfo();
	}

    /// <summary>
    /// 模拟从服务器加载关卡通关数据
    /// </summary>
    void LoadLevelInfo()
    {
        LevelModel currentlevel = new LevelModel(1,"恐怖医院","0306");
        currentLevelModel = currentlevel;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}
