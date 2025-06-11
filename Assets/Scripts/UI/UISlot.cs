using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Button button;
    public Image image;
    public GameObject equipMark;
    
    private Item _item;

    public void SetItem(Item item)
    {
        _item = item;   
    }

    public Item GetItem()
    {
        return _item;
    }
}
