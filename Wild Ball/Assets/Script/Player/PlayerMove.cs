using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Rigidbody playerRigidbody;
    private Vector3 endPoint;

    private float horizontal, vertical;

    // Start is called before the first frame update
    void Start()
    {
        endPoint.y = transform.position.y;
        playerRigidbody = player.GetComponent<Rigidbody>();
        playerRigidbody.sleepThreshold = 100;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (horizontal > 0 || horizontal < 0) 
        {
            endPoint.x = player.transform.position.x + horizontal;
            MovePlayer();
        }
        else if (vertical > 0 || vertical < 0) 
        {
            endPoint.z = player.transform.position.z + vertical;
            MovePlayer();
        }
    }

    /// <summary>
    /// Делаем плавное перемещение объекта 
    /// </summary>
    private void MovePlayer() => player.transform.position = Vector3.Lerp(player.transform.position, endPoint, 1f * Time.deltaTime);

}
