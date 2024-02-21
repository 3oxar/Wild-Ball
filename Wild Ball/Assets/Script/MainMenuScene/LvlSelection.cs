using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelection : MonoBehaviour
{
    
    private void Start()
    {
        Pause(1);//��� �������� ������ �������� ���� �� 1 
    }

    /// <summary>
    /// ���������� ����� �� Id
    /// </summary>
    /// <param name="sceneId">��������� Id</param>
    public void OpenScene(int sceneId) => SceneManager.LoadScene(sceneId);

    /// <summary>
    /// ������� �����
    /// </summary>
    public void RestartScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    /// <summary>
    /// ������������� �������� ���� 
    /// </summary>
    /// <param name="timeSpeed">�������� ���� (0 = �����, 1 = ���������� ��� ����)</param>
    public void Pause(int timeSpeed) => Time.timeScale = timeSpeed;
       
    /// <summary>
    /// ������� �� ��������� ������� 
    /// </summary>
    public void NextLvl()=>  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
          
}
