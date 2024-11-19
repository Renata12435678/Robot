using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraChangeButton : MonoBehaviour
{
    public GameObject CameraTop;
    public GameObject Camera3d;
    public TMP_Text CameraText;
    public void ChangeCamera()
    {
        if (CameraText.text == "Переключиться на вид сверху")
        {
            CameraTop.SetActive(true);
            Camera3d.SetActive(false);
            CameraText.text = "Переключиться на вид от третьего лица";
        }
        else
        {
            CameraTop.SetActive(false);
            Camera3d.SetActive(true);
            CameraText.text = "Переключиться на вид сверху";
        }
    }
        
}
