using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("Buttons")]
    public Button exitButton;

    [Header("Texts")] 
    public TextMeshProUGUI atk;
    public TextMeshProUGUI def;
    public TextMeshProUGUI hp;
    public TextMeshProUGUI crit;



    void Start()
    {
        exitButton.onClick.AddListener(() => GameManager.Instance.uiManager.OnOff(0));
    }


    public void Refresh()
    {
        atk.text = "Atk: " + GameManager.Instance.GetCharacter().FixedAtk();
        def.text = "Def: " + GameManager.Instance.GetCharacter().FixedDef();
        hp.text = "Hp: " + GameManager.Instance.GetCharacter().FixedHp();
        crit.text = "Crit: " + GameManager.Instance.GetCharacter().FixedCrit();
    }
}
