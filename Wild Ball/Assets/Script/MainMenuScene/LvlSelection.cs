using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelection : MonoBehaviour
{
    
    private void Start()
    {
        Pause(1);//при рестарте ставим скорость игры на 1 
    }

    /// <summary>
    /// Открываеть сцену по Id
    /// </summary>
    /// <param name="sceneId">принемает Id</param>
    public void OpenScene(int sceneId) => SceneManager.LoadScene(sceneId);

    /// <summary>
    /// Рестарт сцены
    /// </summary>
    public void RestartScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    /// <summary>
    /// Устанавливаем скорость игры 
    /// </summary>
    /// <param name="timeSpeed">Скорость игры (0 = пауза, 1 = нормальный ход игры)</param>
    public void Pause(int timeSpeed) => Time.timeScale = timeSpeed;
       
    /// <summary>
    /// Переход на следующий уровень 
    /// </summary>
    public void NextLvl()=>  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
          
}
