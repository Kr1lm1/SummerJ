using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText;

    private float currentTime = 0f;

    void Start()
    {
        // Обнуляем таймер при запуске
        currentTime = 0f;
    }

    void FixedUpdate()
    {
        // Увеличиваем текущее время в секундах
        currentTime += Time.fixedDeltaTime;

        // Отображаем текущее время на текстовом элементе
        timeText.text = "Время: " + currentTime.ToString("F2"); // "F2" указывает, что выводим два знака после запятой
    }
}