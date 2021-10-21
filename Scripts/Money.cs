using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    [SerializeField] private TMP_Text _goldText;
    public int Gold
    {
        get => PlayerPrefs.GetInt("gold", 10000);
        private set => PlayerPrefs.SetInt("gold", value);
    }

    private void Update()
    {
        _goldText.text = $"Gold: {Gold}";
    }

    public void AddGold(int value)
    {
        Gold += value;
    }

    public void RemoveGold(int value)
    {
        Gold -= value;
    }
}
