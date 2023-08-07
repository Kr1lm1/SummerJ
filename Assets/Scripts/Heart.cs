using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] private int numberHeart;
    [SerializeField] private int playerHealth;

    void Update()
    {
        if (numberHeart > playerHealth)
        {
            gameObject.SetActive(false);
        }
    }

}