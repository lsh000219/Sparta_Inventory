
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Canvas")]
    public Canvas inventory;
    public Canvas status;
    public Canvas mainMenu;
    
    [Header("Texts")] 
    public TextMeshProUGUI name;
    public TextMeshProUGUI level;
    public TextMeshProUGUI gold;
    
    [Header("Scripts")]
    public UIMainMenu uiMainMenu;
    public UIInventory uiInventory;
    public UIStatus uiStatus;

    private void Start()
    {
        Refresh();
    }

    public void Refresh()   //UI에 나와있는 레벨, 골드 표기 초기화
    {
        name.text = GameManager.Instance.GetCharacter().Name;
        level.text = "Level: " + GameManager.Instance.GetCharacter().Level;
        gold.text = "Gold: " + GameManager.Instance.GetCharacter().Gold;
        
        uiStatus.Refresh();
    }


    public void OnOff(int i)    //UI 화면 전환
    {
        switch (i)
        {
            case 0:
                mainMenu.gameObject.SetActive(true);
                status.gameObject.SetActive(false);
                inventory.gameObject.SetActive(false);
                break;
            case 1:
                mainMenu.gameObject.SetActive(false);
                status.gameObject.SetActive(true);
                inventory.gameObject.SetActive(false);
                break;
            case 2:
                mainMenu.gameObject.SetActive(false);
                status.gameObject.SetActive(false);
                inventory.gameObject.SetActive(true);
                break;
        }
    }
}