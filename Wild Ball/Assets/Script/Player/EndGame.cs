using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] private Canvas endGameCanvas;
    [SerializeField] private Canvas MenuCanvas;

    private LvlSelection lvlSelection;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish")) lvlSelection.NextLvl();
    }

    public void EndGames()
    {
        lvlSelection = new LvlSelection();
        lvlSelection.Pause(0);
        endGameCanvas.gameObject.SetActive(true);
    }
}
