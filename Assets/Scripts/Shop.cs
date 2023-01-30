using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private CoinManager _coinManager;

    private PlayerModifier _playerModifier;

    private void Start()
    {
        _playerModifier = FindObjectOfType<PlayerModifier>();
    }
    public void BuyWidth()
    {
        if (_coinManager.NumberOfCoins >= 10)
        {
            _coinManager.SpendMoney(10);
            Progress.Instance.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.Width += 35;
            _playerModifier.SetWidth(Progress.Instance.Width);
        }
    }
    public void BuyHeight() 
    {
        if (_coinManager.NumberOfCoins >= 10)
        {
            _coinManager.SpendMoney(10);
            Progress.Instance.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.Height += 25;
            _playerModifier.SetHeight(Progress.Instance.Height);
        }
    } 
}
