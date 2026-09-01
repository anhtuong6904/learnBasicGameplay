using UnityEngine;

public abstract class EntityManager : MonoBehaviour
{
    public int Lives;
    public Hunger entityHunger;

    void Awake()
    {
        entityHunger.setAmountToBeFed(Lives);
    }

    public void LossLives(int amount)
    {
        entityHunger.Feed(amount);
        if (entityHunger.IsDead)
        {
            DestroyEntity();
        }
        Debug.Log($"{gameObject.tag} lost 1 blood!!");
    }

    public virtual void DestroyEntity()
    {
        Destroy(gameObject);
    }
}
