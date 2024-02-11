using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Rigidbody playerRigidbody;
    private Vector3 endPoint;

    private float horizontal, vertical;
    [SerializeField, Range (1, 5)] float speed = 1f;

    public static bool changeCamera = false;

    // Start is called before the first frame update
    void Start()
    {
        endPoint = transform.position;
        playerRigidbody = player.GetComponent<Rigidbody>();
        playerRigidbody.sleepThreshold = 100;
        changeCamera = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        if (horizontal > 0 || horizontal < 0)
        {
            if (!changeCamera) 
                endPoint.x = player.transform.position.x + horizontal;
            else
                endPoint.z = player.transform.position.z - horizontal;
            MovePlayer();
        }
        else if (vertical > 0 || vertical < 0)
        {
            if(!changeCamera)
                endPoint.z = player.transform.position.z + vertical;
            else
                endPoint.x = player.transform.position.x + vertical;
            MovePlayer();
        }
    }

    /// <summary>
    /// Делаем плавное перемещение объекта 
    /// </summary>
    private void MovePlayer() => player.transform.position = Vector3.Lerp(player.transform.position, endPoint, speed * Time.deltaTime);

}
