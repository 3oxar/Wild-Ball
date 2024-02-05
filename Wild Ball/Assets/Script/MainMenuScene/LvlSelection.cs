using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelection : MonoBehaviour
{
    /// <summary>
    /// Открываеть сцену по Id
    /// </summary>
    /// <param name="sceneId">принемает Id</param>
    public void OpenScene(int sceneId) => SceneManager.LoadScene(sceneId);
       
}
