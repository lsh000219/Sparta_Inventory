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

        for (int i = 0; i < slotLimit; i++)   //아이템 슬롯 추가
        {
            GameObject newQuestCell = Instantiate(slotPrefab, slotList.transform);
            UISlot slot = newQuestCell.GetComponent<UISlot>();

            if (i < GameManager.Instance.itemData.items.Length)  //슬롯애 넣을 아이템이 있다면
            {
                slot.image.sprite = GameManager.Instance.itemData.items[i].itemImage; 
                int j = i;
                slot.button.onClick.AddListener(() => Clicked(j));
            }
            
            _slots.Add(slot);
        }
    }

    private void Clicked(int i)  //아이템 칸을 눌렀을 때 처리
    {
        int j = 0;
        foreach (UISlot slot in _slots)
        {
            slot.equipMark.SetActive(false);  //장착 마크 해제
            
            if (j == i)
            {
                slot.equipMark.SetActive(true);   //선택한 아이템은 장착마크 ON + 장착처리
                GameManager.Instance.Equip(j);
            }

            j++;
        }
        
    }
}
