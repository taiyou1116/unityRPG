using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slot : MonoBehaviour
{
   public Image icon;
   public GameObject removeButton;
   Item item;

   public void AddItem(Item newItem)
   {
       item = newItem;
       icon.sprite = newItem.icon;
       removeButton.SetActive(true);
   }

   public void ClearSlot()
   {
       item = null;
       icon.sprite = null;
       removeButton.SetActive(false);
   }

   public void OnRemoveButton()
   {
       Inventry.instance.Remove(item);
   }

   public void UseItem()
   {
       if(item == null)
       {
           return;
       }
       if(item.name == "tank")
       {
           Debug.Log("a");
       }
   }
}
