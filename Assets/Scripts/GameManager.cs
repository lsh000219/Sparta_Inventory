using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;
    public ItemData itemData;
    
    private Character _character;
    
    public static GameManager Instance;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        _character = new Character();
    }

    void OnEnable()
    {
        SetData();
    }

    public Character GetCharacter()
    {
        return _character;
    }

    public void SetData()
    {
        _character.SetInventory(itemData);
    }

    public void Equip(int i)
    {
        _character.Equip(i);
        uiManager.Refresh();
    }
}
