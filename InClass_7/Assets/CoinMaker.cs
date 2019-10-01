using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinMaker : MonoBehaviour
    
{
    public GameObject coin_prefab;
    int coinCount;
    public Slider coinSlider;
    int maxCoins;
    public InputField InputField;

    // Start is called before the first frame update
    void Start()
    {
        maxCoins = 30;
    }

    public void CreateCoin()
    {
        coinSlider.value = coinCount;
        Instantiate(coin_prefab, new Vector2(Random.Range(393, 900), 650), Quaternion.identity);
        coinCount++;
       // Debug.Log(coinCount);

        if (coinCount > maxCoins)
        {
            RemoveCoin();
        }
    }

    public void RemoveCoin()
    {
        GameObject[] allcoins;
        allcoins = GameObject.FindGameObjectsWithTag("coin");
        if (allcoins.Length >= 1)
        {

            int randomCoin = Random.Range(0, allcoins.Length - 1);
            Destroy(allcoins[randomCoin]);
            coinCount--;
            coinSlider.value = coinCount;

        }

    }

    public void SliderUpdate()
    {
       // Debug.Log(coinSlider.value);
        if (coinSlider.value > coinCount)
        {
            CreateCoin();
        } else if (coinSlider.value < coinCount){
            RemoveCoin();
        }
    }

    public void TextUpdated()
    {
        Debug.Log(InputField.text);
        if (InputField.text == "bonus")
        {
            maxCoins = 50;
            coinSlider.maxValue = 50;
            //coinSlider.value = 50;
            //coinCount = 50;
            int difference = maxCoins - coinCount;
            for (int i = 0; i <= difference; i++)
            {
                CreateCoin();
                
            }
            InputField.text = ("");
        } else if (InputField.text == "blue"){
            coin_prefab.GetComponent<SpriteRenderer>().color = Color.blue;
            InputField.text = "";
        }
     else if (InputField.text == "yellow"){
            coin_prefab.GetComponent<SpriteRenderer>().color = Color.yellow;
            InputField.text = "";
        } else if (InputField.text == "rainbow")
        {
            GameObject[] allCoins;
            allCoins = GameObject.FindGameObjectsWithTag("coin");

            for (int i = 0; i <= allCoins.Length - 1; i++)
            {
                allCoins[i].GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

            }
            InputField.text = ("");

        }
      
    }

}
