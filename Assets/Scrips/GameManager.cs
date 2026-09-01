using UnityEngine;

enum GameState
{
    Start, 
    Playing,
    Paused,
    GameOver
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private GameState currentGameState;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        currentGameState = GameState.Start;
    }

    void Start()
    {

    }
    public void GameStart()
    {
        currentGameState = GameState.Playing;
        Debug.Log("Game Start!!");
    }

    public void Pause()
    {
        currentGameState = GameState.Paused;
        Debug.Log("Pause game");
    }

    public void GameOver()
    {
        currentGameState = GameState.GameOver;
        Debug.Log("Game Over!!");
    }
}
