using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    
	public int coins;

	public Text TextCoins;

	private void Start()
	{
		if (PlayerPrefs.HasKey("Coins"))
		{
			coins = PlayerPrefs.GetInt("Coins");
			TextCoins.text = coins.ToString(); // сохранение счетчика монет после завершения игры
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Money") //если машина касается объекта монеты с тегом money
		{
			coins++; //счетчик увеличивается
			other.gameObject.SetActive(false);
			TextCoins.text = coins.ToString();
			PlayerPrefs.SetInt("Coins", coins); // сохранение счетчика монет после завершения игры
		}
	}
}
