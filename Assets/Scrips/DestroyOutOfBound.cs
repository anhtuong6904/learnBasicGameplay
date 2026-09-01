using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 40.0f;
    private float lowerBound = -10.0f;
    private float sideBound = 40.0f;

    void Start()
    {

    }

    void Update()
    {
        //destroy cac object khi di ra khoi khung hinh
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -sideBound || transform.position.x > sideBound)
        {
            Destroy(gameObject);
        }
    }
}
