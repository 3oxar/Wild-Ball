using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    /// <summary>
    /// Меняем состояние камеры 
    /// </summary>
    public void ChangeCameraPlayer() => PlayerMove.changeCamera = !PlayerMove.changeCamera;

}
