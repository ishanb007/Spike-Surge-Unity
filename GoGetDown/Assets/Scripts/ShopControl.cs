using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControl : MonoBehaviour {

    public GameObject[] purchaseButton;
    public GameObject[] selectButtons;

    public float Price = 200f;

    public Text currency;

    private void Start()
    {
        currency.text = PlayerPrefs.GetFloat("currency").ToString();

      //  if (PlayerPrefs.GetInt("purchase1") == 1)
       // {
        //    purchaseButton[0].SetActive(false);
          //  selectButtons[0].SetActive(true);
       // }
        if (PlayerPrefs.GetInt("purchase2") == 1)
        {
            purchaseButton[1].SetActive(false);
            selectButtons[1].SetActive(true);
        }
        if (PlayerPrefs.GetInt("purchase3") == 1)
        {
            purchaseButton[2].SetActive(false);
            selectButtons[2].SetActive(true);
        }
        if (PlayerPrefs.GetInt("purchase4") == 1)
        {
            purchaseButton[3].SetActive(false);
            selectButtons[3].SetActive(true);
        }
        if (PlayerPrefs.GetInt("purchase5") == 1)
        {
            purchaseButton[4].SetActive(false);
            selectButtons[4].SetActive(true);
        }
        if (PlayerPrefs.GetInt("purchase6") == 1)
        {
            purchaseButton[5].SetActive(false);
            selectButtons[5].SetActive(true);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

   // public void Purchase()
    //{
      //  if (PlayerPrefs.GetFloat("currency") >= Price)
        //{
          //  PlayerPrefs.SetFloat("currency", PlayerPrefs.GetFloat("currency") - Price);
            //PlayerPrefs.SetInt("purchase1", 1);
            //purchaseButton[0].SetActive(false);
            //selectButtons[0].SetActive(true);
            //currency.text = PlayerPrefs.GetFloat("currency").ToString();
       // }
    //}
  public  void Purchase2()
    {
        if (PlayerPrefs.GetFloat("currency") >= Price)
        {
            PlayerPrefs.SetFloat("currency", PlayerPrefs.GetFloat("currency") - Price);
            PlayerPrefs.SetInt("purchase2", 1);
            purchaseButton[1].SetActive(false);
            selectButtons[1].SetActive(true);
            currency.text = PlayerPrefs.GetFloat("currency").ToString();
        }
    }
   public void Purchase3()
    {
        if (PlayerPrefs.GetFloat("currency") >= Price)
        {
            PlayerPrefs.SetFloat("currency", PlayerPrefs.GetFloat("currency") - Price);
            PlayerPrefs.SetInt("purchase3", 1);
            purchaseButton[2].SetActive(false);
            selectButtons[2].SetActive(true);
            currency.text = PlayerPrefs.GetFloat("currency").ToString();
        }
    }
    public void Purchase4()
    {
        if (PlayerPrefs.GetFloat("currency") >= Price)
        {
            PlayerPrefs.SetFloat("currency", PlayerPrefs.GetFloat("currency") - Price);
            PlayerPrefs.SetInt("purchase4", 1);
            purchaseButton[3].SetActive(false);
            selectButtons[3].SetActive(true);
            currency.text = PlayerPrefs.GetFloat("currency").ToString();
        }
    }
    public void Purchase5()
    {
        if (PlayerPrefs.GetFloat("currency") >= Price)
        {
            PlayerPrefs.SetFloat("currency", PlayerPrefs.GetFloat("currency") - Price);
            PlayerPrefs.SetInt("purchase5", 1);
            purchaseButton[4].SetActive(false);
            selectButtons[4].SetActive(true);
            currency.text = PlayerPrefs.GetFloat("currency").ToString();
        }
    }
    public void Purchase6()
    {
        if (PlayerPrefs.GetFloat("currency") >= Price)
        {
            PlayerPrefs.SetFloat("currency", PlayerPrefs.GetFloat("currency") - Price);
            PlayerPrefs.SetInt("purchase6", 1);
            purchaseButton[5].SetActive(false);
            selectButtons[5].SetActive(true);
            currency.text = PlayerPrefs.GetFloat("currency").ToString();
        }
    }

    public void Select()
    {
        PlayerPrefs.SetInt("skin", 1);
    }
    public void Select2()
    {
        PlayerPrefs.SetInt("skin", 2);
    }
    public void Select3()
    {
        PlayerPrefs.SetInt("skin", 3);
    }
    public void Select4()
    {
        PlayerPrefs.SetInt("skin", 4);
    }
    public void Select5()
    {
        PlayerPrefs.SetInt("skin", 5);
    }
    public void Select6()
    {
        PlayerPrefs.SetInt("skin", 6);
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
