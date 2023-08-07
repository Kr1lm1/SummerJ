using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class TimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private float currentTime = 0f;

    void Update()
    {
        // Получаем текущее время в секундах
        currentTime = Time.time;

        // Отображаем текущее время на текстовом элементе
        timeText.text = "Время: " + currentTime.ToString("F2");
    }
}