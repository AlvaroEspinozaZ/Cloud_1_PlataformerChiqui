using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class GameController : MonoBehaviour
{
    [SerializeField] private List<Coin> _listCoins;
    [SerializeField] private Coin _WinCoins;

    [SerializeField] private TextMeshProUGUI coins;
    [SerializeField] private TextMeshProUGUI lifes;

    [SerializeField] UnityEvent _win;
    int total;
    void Start()
    {
        for(int i=0; i < _listCoins.Count; i++)
        {
            _listCoins[i].gaisnCoin += GainCoins;  
        }
        _WinCoins.gaisnCoin += WIN;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GainCoins(Coin c)
    {
        total = total + c.points;
        coins.text = "Coins : " + total;
        c.gameObject.SetActive(false);
    }
    void WIN(Coin c)
    {
        c.gameObject.SetActive(false);
        _win?.Invoke();
    }
}
