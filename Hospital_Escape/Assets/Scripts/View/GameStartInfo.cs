using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameStartInfo : MonoBehaviour {

    private Text text;
	void Start () {
        text = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        HideInfo();
	}

    void HideInfo()
    {
        text.CrossFadeColor(Color.clear, 4f, false, true);
    }
}
