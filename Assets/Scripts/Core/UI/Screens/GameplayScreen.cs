using System.Collections;
using System.Collections.Generic;
using CORE.UI;
using TMPro;
using UnityEngine;

public class GameplayScreen : AbstractScreen
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;

    public void UpdateScoreView(int newScore)
    {
        _scoreText.text = newScore.ToString();
    }
}
