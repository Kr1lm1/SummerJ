using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class TimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private float currentTime = 0f;

    void Update()
    {
        // �������� ������� ����� � ��������
        currentTime = Time.time;

        // ���������� ������� ����� �� ��������� ��������
        timeText.text = "�����: " + currentTime.ToString("F2");
    }
}