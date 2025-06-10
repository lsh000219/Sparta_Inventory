using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "Item/ItemData")]
public class ItemData: ScriptableObject
{
    public Item[] items;
}