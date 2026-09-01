using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    enum Direction
    {
        Top = 0,
        Right = 1,
        Left = 2,
    }
    public GameObject[] animalPrefab;
    private Direction[] directionData = { Direction.Top, Direction.Right, Direction.Left };
    private float spawnRageX = 20.0f;
    private float spawnRageZ = 15.0f;
    private float startDelay = 1f;
    private float spawnInterval = 1f;

    private Vector3 posRandom(Direction dir)
    {
        switch (dir)
        {
            case Direction.Top:
                return new Vector3(Random.Range(-spawnRageX, spawnRageX), 0, 30.0f);
            case Direction.Left:
                return new Vector3(-spawnRageX, 0, Random.Range(0, spawnRageZ));
            case Direction.Right:
                return new Vector3(spawnRageX, 0, Random.Range(0, spawnRageZ));
            default:
                return Vector3.zero;
        }
    }
    private Quaternion quaRandom(Direction dir)
    {
        switch (dir)
        {
            case Direction.Top:
                return Quaternion.AngleAxis(-180, Vector3.up);
            case Direction.Left:
                return Quaternion.AngleAxis(90, Vector3.up);
            case Direction.Right:
                return Quaternion.AngleAxis(-90, Vector3.up);
            default:
                return Quaternion.AngleAxis(0, Vector3.up);
        }
    }
    private void spawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Direction dirRandom = (Direction)Random.Range(0, directionData.Length);
        Vector3 spawnPos = posRandom(dirRandom);
        Quaternion quaternion = quaRandom(dirRandom);
        Instantiate(animalPrefab[animalIndex], spawnPos,
                    quaternion);
    }

    void Start()
    {
        InvokeRepeating("spawnRandomAnimals", startDelay, spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
