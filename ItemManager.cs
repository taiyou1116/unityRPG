using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemManager : MonoBehaviour
{
    public Item item;
    

    void Start()
    {
        GetComponent<Image>().sprite = item.icon;
    }

    
    public void PickUp()
    {
        Inventry.instance.Add(item);
        Destroy(gameObject);
    }
}
