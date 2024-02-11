using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    [SerializeField] private Canvas playerCanvas;

    private bool blocked = true;
    private bool openOrClose = false;
    private bool stateDoor = false;//false - закрыто, true - открыта 

    private void Update()
    {
        if (openOrClose && !blocked && !stateDoor)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                doorAnimator.Play("DoorOpen");
                stateDoor = true;
                playerCanvas.transform.Find("DoorOpenButtonText(TMP)").gameObject.SetActive(false);
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interaction"))
        {
            blocked = false;

            other.transform.GetChild(0).gameObject.GetComponent<Animation>().Play();
            Destroy(other.GetComponent<Collider>());//убираем колайдер что бы нре проигрывать анимацию снова
        }

        if (other.CompareTag("Door") && !blocked)
        {
            openOrClose = true;
            playerCanvas.transform.Find("DoorOpenButtonText(TMP)").gameObject.SetActive(true);
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            openOrClose = false;
            playerCanvas.transform.Find("DoorOpenButtonText(TMP)").gameObject.SetActive(false);
        }

        if (other.CompareTag("Door") && stateDoor)
        {
            doorAnimator.Play("DoorClose");
            stateDoor = false;
           
        }
    }
}
