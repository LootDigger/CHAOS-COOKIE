using System;
using CORE.UI;
using TMPro;
using UnityEngine;

public class ADPauseScreen : AbstractScreen
{
    [SerializeField]
    private TextMeshProUGUI _countDownText;

    public void UpdatePauseTimerView(int countdownTime)
    {
        _countDownText.text = TimeSpan.FromSeconds(countdownTime).ToString();
    }
}
