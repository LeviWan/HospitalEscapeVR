using UnityEngine;
using System.Collections;

public class ScreenAdaptation : MonoBehaviour
{


    const float devHeight = 9.6f;
    const float devWidth = 6.4f;


    void Start()
    {

        float screenHeight = Screen.height;
        Debug.Log("screenHeight=" + screenHeight);

        float orthographicSize = this.GetComponent<Camera>().orthographicSize;//拿到相机的正交属性大小。

        float aspectRatio = Screen.width * 1.0f / Screen.height; //宽高比

        float cameraWidth = orthographicSize * 2 * aspectRatio;

        if (cameraWidth < devWidth)//如果相机的宽度小于设计的尺寸宽度
        {
            orthographicSize = devWidth / (2 * aspectRatio);
            Debug.Log("new orthographicSize=" + orthographicSize);

            this.GetComponent<Camera>().orthographicSize = orthographicSize;
        }
    }



}
