using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCamera : MonoBehaviour
{
    
    /// <summary>
    /// ������ ��������� ������ 
    /// </summary>
    public void ChangeCameraPlayer() => PlayerMove.changeCamera = !PlayerMove.changeCamera;

}
