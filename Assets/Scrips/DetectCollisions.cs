using Unity.VisualScripting;
using UnityEngine;

public class Colider : MonoBehaviour
{
    private GameManager gameManager;
    void Awake()
    {
        gameManager = GameManager.Instance;
    }
    void Start()
    {

    }

    void Update()
    {

    }
    //xu ly khi trigger collision
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerManager>().LossLives(1); ;
        }
        else if (other.CompareTag("Bullet"))
        {
            gameObject.GetComponent<AnimalManager>().LossLives(1);
            if (gameObject.GetComponent<AnimalManager>().entityHunger.IsDead)
            {
                GameObject.Find("Player").GetComponent<PlayerManager>().AddScore();
            }
            Destroy(other.gameObject);
        }
    }
}
