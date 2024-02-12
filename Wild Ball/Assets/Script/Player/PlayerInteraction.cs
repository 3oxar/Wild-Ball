using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] private Canvas playerCanvas;

    private Animator doorAnimator;
    private Animation doorButtonAnimation;

    private GameObject doorOpenButtonText;

    private bool blocked = true;
    private bool openOrClose = false;
    private bool stateDoor = false;//false - �������, true - ������� 

    private void Awake()
    {
        if(door != null) 
            doorAnimator = door.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Animator>();
        if (door != null)
            doorButtonAnimation = door.transform.GetChild(1).gameObject.transform.GetChild(0).GetComponent<Animation>();

        doorOpenButtonText = playerCanvas.transform.Find("DoorOpenButtonText(TMP)").gameObject;
    }

    private void Update()
    {
        if (openOrClose && !blocked && !stateDoor)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                doorAnimator.Play("DoorOpen");
                stateDoor = true;
                doorOpenButtonText.SetActive(false);
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interaction"))
        {
            blocked = false;

            doorButtonAnimation.Play();
            Destroy(other.GetComponent<Collider>());//������� �������� ��� �� ��� ����������� �������� �����
        }

        if (other.CompareTag("Door") && !blocked)
        {
            openOrClose = true;
          doorOpenButtonText.SetActive(true);
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
