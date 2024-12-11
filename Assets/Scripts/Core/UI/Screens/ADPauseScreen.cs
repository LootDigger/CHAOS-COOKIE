using System.Collections;
using System.Collections.Generic;
using CORE.UI;
using TMPro;
using UnityEngine;

public class ADPauseScreen : AbstractScreen
{
    [SerializeField]
    private TextMeshProUGUI _countDownText;

    public void UpdatePauseTimerView(int newScore)
    {
        _countDownText.text = newScore.ToString();
    }
}
