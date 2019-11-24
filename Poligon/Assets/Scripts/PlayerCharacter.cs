using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    private int _health = 10;
    private int maxHealth = 100;
    private int maxHealthAid = 75;
    public Slider slider;

    public void Hurt(int damage)
    {
        _health -= damage;//уменьшение здоровья игрока
        slider.value = _health;
        if (_health <= 0)
        {
            SceneManager.LoadScene("MainMenu");//Загрузка главного меню
        }
        Debug.Log("Health: " + _health);
    }

    public void ChangeHealth(int value)
    {
        if(value == 75 && _health < 75)
        {
            _health = maxHealthAid;
        }
        else if(value == 100 && _health < 100){
            _health = maxHealth;
        }
        if(_health >= maxHealth){
            _health = maxHealth;
        }
        Debug.Log("Health: " + _health + "/" + maxHealth);
    }
}
