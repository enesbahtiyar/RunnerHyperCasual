using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    PlayerController playerController;
    CollectCoin collectCoin;
    Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        playerController = FindObjectOfType<PlayerController>();
        collectCoin = FindObjectOfType<CollectCoin>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            //ReloadScene();
            playerController.enabled = false;

            if(collectCoin.currentGold >= 75)
            {
                animator.SetBool("isWin", true);
                transform.Rotate(0, 180, 0);

            }
            else
            {
                animator.SetBool("isLose", true);
                transform.Rotate(0, 180, 0); 
            }
        }
    }

    private void ReloadScene()
    {
        Scene currentscene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentscene.buildIndex);
    }
}
