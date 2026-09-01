using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public float speed = 10.0f;
    public InputAction moveAction;
    public InputAction fireAction;
    private Vector2 moveInput;
    public float xRage;
    public float zRage;
    public GameObject projectilePrefab;
    void Start()
    {
        //enable input system
        //cap quyen cho input system
        moveAction.Enable();
        fireAction.Enable();
    }

    void Update()
    {
        //giu cho player luon trong man hinh
        //Keep the  player in bound
        if (transform.position.x < -xRage)
        {
            transform.position = new Vector3(-xRage, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRage)
        {
            transform.position = new Vector3(xRage, transform.position.y, transform.position.z);
        }
        if (transform.position.z <= 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        if (transform.position.z < zRage)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRage);
        }
        moveInput = moveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.right * Time.deltaTime * speed * moveInput.x);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        //trigger fireAction 
        if (fireAction.triggered)
        {
            //khoi tao doi tuong tai parent position va rotation
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            // Debug.Log("FIRED!!!");
        }
    }
}
