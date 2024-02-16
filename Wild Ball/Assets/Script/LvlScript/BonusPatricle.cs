using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPatricle : MonoBehaviour
{
    [SerializeField] private ParticleSystem bonusParticle;
    [SerializeField] private GameObject coin;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(coin);
            bonusParticle.Play();
            StartCoroutine(DestroyObj());
        }
    }

    private IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }

}
