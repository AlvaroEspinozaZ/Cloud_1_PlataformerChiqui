using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    [SerializeField] private List<Coin> _listCoins;
    [SerializeField] private Coin _WinCoins;

    [SerializeField] private TextMeshProUGUI coins;
    [SerializeField] private TextMeshProUGUI lifes;

    [SerializeField] UnityEvent _win;
    [SerializeField] UnityEvent _dead;
    [SerializeField] private PLayerController _player;
    [SerializeField] private SpawMeteorito _spawm;
    [SerializeField] private int direction;
    [SerializeField] private float velocityMeteorite;
    int total;
    void Start()
    {
        for(int i=0; i < _listCoins.Count; i++)
        {
            _listCoins[i].gaisnCoin += GainCoins;  
        }
        _WinCoins.gaisnCoin += WIN;


        _player.Life_n += Dead;


        _spawm._SpawMeteorito += Spw;

        
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
    void Dead(PLayerController p)
    {
        _player.GetComponent<Transform>().position = new Vector2(-6,3);
        p.life-=1;
        lifes.text = "Lifes : " + p.life;
        if (p.life <= 0)
        {
            _dead?.Invoke();
        }
        _player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }

    public void Spw()
    {
        _spawm.SpwamMeteoritos(direction, velocityMeteorite);
    }   
 
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
