using UnityEngine;

public class PlayerManager : EntityManager
{
    private int currentScore = 0;
    public void AddScore()
    {
        currentScore++;
        Debug.Log($"current Score: {currentScore}");
    }
    public override void DestroyEntity()
    {
        base.DestroyEntity();
        GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
    }
}
