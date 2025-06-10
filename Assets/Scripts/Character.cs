using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int inventoryLength;
    private int lastCell;
    
    private string _name;
    private int _level;
    private int _gold;

    private int _atk;
    private int _def;
    private int _hp;
    private int _crit;

    private List<Item> _inventory;

    private Item _equipItem;
    
    public Character()
    {
        Name = "name";
        Level = 1;
        Gold = 5000;
        Atk = 15;
        Def = 15;
        Hp = 500;
        Crit = 0;
        
        _inventory=new List<Item>();
    }
    
    public string Name{get{return _name;} private set{_name = value;}}
    public int Level{get{return _level;} private set{_level = value;}}
    public int Gold{get{return _gold;} private set{_gold = value;}}
    public int Atk{
        get{return _atk;} 
        private set{_atk = value;}
        
    }
    public int Def{get{return _def;} private set{_def = value;}}
    public int Hp{get{return _hp;} private set{_hp = value;}}
    public int Crit{get{return _crit;} private set{_crit = value;}}

    public int FixedAtk()
    {
        if (_equipItem == null)
        {
            return _atk;
        }
        return _atk + _equipItem.atk;
    }
    public int FixedDef()
    {
        if (_equipItem == null)
        {
            return _def;
        }
        return _def + _equipItem.def;
    }
    public int FixedHp()
    {
        if (_equipItem == null)
        {
            return _hp;
        }
        return _hp + _equipItem.hp;
    }
    public int FixedCrit()
    {
        if (_equipItem == null)
        {
            return _crit;
        }
        return _crit + _equipItem.crit;
    }

    public void SetInventory(ItemData items)
    {
        foreach (Item i in items.items)
        {
            _inventory.Add(i);
        }
        lastCell = items.items.Length;
    }

    public void Additem(Item item)
    {
        _inventory[lastCell] = item;
        lastCell++;
    }

    public void Equip(int i)
    {
        _equipItem = _inventory[i];
        Debug.Log(i);
    }

    public void UnEquip()
    {
        _equipItem = null;
    }
}
