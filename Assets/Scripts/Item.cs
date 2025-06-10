using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item
{
    public Sprite itemImage;
    public int atk;
    public int def;
    public int hp;
    public int crit;


    
    public Item(Sprite image, int atk, int def, int hp, int crit)
    {
        itemImage = image;
        this.atk = atk;
        this.def = def;
        this.hp = hp;
        this.crit = crit;
    }











}
