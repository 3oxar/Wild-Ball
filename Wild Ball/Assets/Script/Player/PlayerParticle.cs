using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParticle : MonoBehaviour
{

    [SerializeField] private ParticleSystem playerDeadParticle;

    private EndGame endGame;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;//убираем отображение шара
            endGame = GetComponent<EndGame>();
            playerDeadParticle.Play();
            StartCoroutine(EndGames());
        }
    }

    private IEnumerator EndGames()
    {
        yield return new WaitForSeconds(0.5f);
        endGame.EndGames();
    }
}
