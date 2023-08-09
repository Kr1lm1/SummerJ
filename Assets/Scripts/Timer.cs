using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText;

    private float currentTime = 0f;

    void Start()
    {
        // �������� ������ ��� �������
        currentTime = 0f;
    }

    void FixedUpdate()
    {
        // ����������� ������� ����� � ��������
        currentTime += Time.fixedDeltaTime;

        // ���������� ������� ����� �� ��������� ��������
        timeText.text = "�����: " + currentTime.ToString("F2"); // "F2" ���������, ��� ������� ��� ����� ����� �������
    }
}