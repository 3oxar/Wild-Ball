using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] private Canvas endGameCanvas;
    [SerializeField] private Canvas pauseCanvas;

    private LvlSelection lvlSelection;

    private void Awake()
    {
        lvlSelection = new LvlSelection();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            lvlSelection.Pause(0);
            pauseCanvas.gameObject.SetActive(false);
            endGameCanvas.gameObject.SetActive(true);
        }

        if (other.CompareTag("Finish")) lvlSelection.NextLvl();
    }

}
