using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    [SerializeField] private DataBaseShop _dataBaseShop;
    [SerializeField] private Ammunition _ammunition;
    [SerializeField] private Money _money;
    [SerializeField] private GameObject _shopItems;
    [SerializeField] private Transform _content;
    private void Start()
    {
        AddItems();
    }

    private void AddItems()
    {
        for (int i = 0; i < _dataBaseShop.items.Count; i++)
        {
            GameObject newItem = Instantiate(_shopItems, _content);
            newItem.transform.GetChild(0).GetComponent<Image>().color = _dataBaseShop.items[i].Color;
            newItem.transform.GetChild(1).GetComponent<TMP_Text>().text = _dataBaseShop.items[i].Name;
            newItem.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = _dataBaseShop.items[i].Price.ToString();

            int price = _dataBaseShop.items[i].Price;
            int id = _dataBaseShop.items[i].Id;

            Button newButton = newItem.transform.GetChild(2).GetComponent<Button>();
            newButton.onClick.AddListener(delegate { BuyItems(price, id); });
        }
    }

    private void BuyItems(int price, int NumRocket)
    {
        if(_money.Gold > price)
        {
            _money.RemoveGold(price);
            _ammunition.AddRocket(NumRocket);
        }
    }
}
