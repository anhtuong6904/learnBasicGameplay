using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Hunger : MonoBehaviour
{
    //khoi tao cac thong so cua thanh mau bang UI slider
    public Slider hungerSlider;
    private int amountToBeFed;
    private int currentFedAmount = 0;

    public bool IsDead { get; private set; }

    public void setAmountToBeFed(int amo)
    {
        amountToBeFed = amo;
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);
    }

    void Start()
    {

    }

    public void Feed(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;
        if (currentFedAmount >= amountToBeFed)
        {
            IsDead = true;
        }
    }

    void Update()
    {

    }
}
