using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;
    public float delayTime = 0.5f;
    private float nextFireTime = 0.0f;


    void OnEnable()
    {
        fireAction.Enable();
    }

    void OnDisable()
    {
        fireAction.Disable();
    }

    void Start()
    {

    }

    void Update()
    {
        // On spacebar press, send dog
        if (fireAction.triggered && Time.time >= nextFireTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextFireTime = (Time.time + delayTime);
        }
    }
}
