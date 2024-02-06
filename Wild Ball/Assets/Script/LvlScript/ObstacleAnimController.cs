using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnimController : MonoBehaviour
{
    private Animator animator;

    private string[] nameAnimation =
           {"Obstacle#2CubeAnim#1",
            "Obstacle#2CubeAnim#2",
            "Obstacle#2CubeAnim#3",
            "Obstacle#2CubeAnim#4",
            "Obstacle#2CubeAnim#5",
            "Obstacle#2CubeAnim#6",
            "Obstacle#2CubeAnim#7",
            "Obstacle#2CubeAnim#8",};
          

    private int random;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        CheckAndChangeAnimation();
    }

    /// <summary>
    /// Проверяет по индексу какая анимация проигрывалась и запускает другую
    /// </summary>
    public void CheckAndChangeAnimation()
    {
        random = Random.Range(0, 2);

        if (random == 0)
        {
            if (index % 2 != 0) index--;
            else index += 2;

            if (index > nameAnimation.Length - 1) index = 0;
        }
        else if (random == 1)
        {
            if (index % 2 != 0) index-=2;
            else index ++;

            if (index < 0) index = nameAnimation.Length - 1;
        }
        animator.Play(nameAnimation[index]);
    }

    /// <summary>
    /// Выберает в какую сторону будет растягиваться куб
    /// </summary>
    public void ScaleAnimation()
    {
        random = Random.Range (0, 11);

        if (random % 2 == 0) animator.SetBool("Scale", true);
        else animator.SetBool("Scale", false);
        
    }
}












