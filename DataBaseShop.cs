using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBaseShop : MonoBehaviour
{
    public List<Item> items = new List<Item>();
}

[System.Serializable]
public class Item
{
    public int Id;
    public string Name;
    public int Price;
    public Color Color;
}

