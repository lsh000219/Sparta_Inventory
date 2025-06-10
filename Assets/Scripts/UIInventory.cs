using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [Header("Buttons")]
    public Button exitButton;

    [Header("Prefabs")]
    public GameObject slotPrefab;
    public GameObject slotList;
    public int slotLimit;

    private List<UISlot> _slots = new List<UISlot>();

    void Start()
    {
        exitButton.onClick.AddListener(() => GameManager.Instance.uiManager.OnOff(0));

        for (int i = 0; i < slotLimit; i++)
        {
            GameObject newQuestCell = Instantiate(slotPrefab, slotList.transform);
            UISlot slot = newQuestCell.GetComponent<UISlot>();

            if (i < GameManager.Instance.itemData.items.Length)
            {
                slot.image.sprite = GameManager.Instance.itemData.items[i].itemImage;
                int j = i;
                slot.button.onClick.AddListener(() => Clicked(j));
            }
            
            _slots.Add(slot);
        }
    }

    private void Clicked(int i)
    {
        int j = 0;
        foreach (UISlot slot in _slots)
        {
            slot.equipMark.SetActive(false);
            if (j == i)
            {
                slot.equipMark.SetActive(true);
                GameManager.Instance.Equip(j);
            }

            j++;
        }
        
    }
}
