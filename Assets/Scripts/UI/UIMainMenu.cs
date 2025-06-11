using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Buttons")]
    public Button inventoryButton;
    public Button statusButton;
    
    
    
    void Start()
    {
        inventoryButton.onClick.AddListener(() => GameManager.Instance.uiManager.OnOff(2));
        statusButton.onClick.AddListener(() => GameManager.Instance.uiManager.OnOff(1));
    }



}
