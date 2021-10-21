using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ammunition : MonoBehaviour
{
    [SerializeField] private TMP_Text[] _countRocketText;

    public int BlueRocket
    {
        get => PlayerPrefs.GetInt("BlueRocket", 0);
        private set => PlayerPrefs.SetInt("BlueRocket", value);
    }

    public int GreenRocket
    {
        get => PlayerPrefs.GetInt("GreenRocket", 0);
        private set => PlayerPrefs.SetInt("GreenRocket", value);
    }

    public int RedRocket
    {
        get => PlayerPrefs.GetInt("RedRocket", 0);
        private set => PlayerPrefs.SetInt("RedRocket", value);
    }

    private void Update()
    {
        _countRocketText[0].text = BlueRocket.ToString();
        _countRocketText[1].text = GreenRocket.ToString();
        _countRocketText[2].text = RedRocket.ToString();
    }

    public void AddRocket(int NumRocket)
    {
        switch (NumRocket)
        {
            case 0:
                BlueRocket += 1;
                break;
            case 1:
                GreenRocket += 1;
                break;
            case 2:
                RedRocket += 1;
                break;
            default:
                print("Null");
                break;
        }
    }

    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }
}
