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
        if (CameraText.text == "������������� �� ��� ������")
        {
            CameraTop.SetActive(true);
            Camera3d.SetActive(false);
            CameraText.text = "������������� �� ��� �� �������� ����";
        }
        else
        {
            CameraTop.SetActive(false);
            Camera3d.SetActive(true);
            CameraText.text = "������������� �� ��� ������";
        }
    }
        
}
