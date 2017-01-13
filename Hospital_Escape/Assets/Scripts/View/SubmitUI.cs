using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SubmitUI : MonoBehaviour {

    public GameObject pwdPanel;
    public InputField inputF;
    public Vector3 curPosition;

    public Text failed;
    public Text success;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(ResetInputFValue);
        curPosition = (pwdPanel.transform as RectTransform).localPosition;
    }
    public void ResetInputFValue()
    {
        if (inputF.text==LevelManager.instance.currentLevelModel.LevelPassWord)
        {
            GameManager.instance.isGetPasswordToOpenTheChest = true;
            GameManager.instance.isGetKey = true;
            StartCoroutine(SuccessUI());
        }
        else
        {
            StartCoroutine("FailedUI");
        }
    }




    IEnumerator FailedUI()
    {
        pwdPanel.transform.localPosition = new Vector3(1000,1000,1000);
        failed.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        failed.gameObject.SetActive(false);
        pwdPanel.transform.localPosition = curPosition;
       
    }

    IEnumerator SuccessUI()
    {
        pwdPanel.transform.localPosition = new Vector3(1000, 1000, 1000);
        success.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        success.gameObject.SetActive(false);
      

    }
}
