using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
