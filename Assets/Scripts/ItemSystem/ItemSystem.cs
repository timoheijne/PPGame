using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ItemSystem
{
    public class ItemSystem : MonoBehaviour
    {
        public static ItemSystem Instance
        {
            get { return _instance; }
        }
        
        private static ItemSystem _instance;
        private List<Item> _items;

        private void Start()
        {
            if (ItemSystem.Instance == null)
            {
                _instance = this;
                loadItems("Grid Nodes");
            }
            else
            {
                Debug.LogError("ItemSystem already exists.");
                Destroy(this);
            }
        }

        private void loadItems(string path)
        {
            _items = Resources.LoadAll<Item>(path).ToList();

            foreach (Item item in _items)
            {
                List<Item> itemDuplicateCheck = _items.FindAll(i => i.UniqueItemId == item.UniqueItemId).ToList();

                if (itemDuplicateCheck.Count > 1)
                {
                    Debug.LogError($"ItemID {item.UniqueItemId} exists {itemDuplicateCheck.Count} times (found on item: {item.ItemName})");
                }
            }
        }
 
        public Item GetItemByID(int itemId)
        {
            return _items.Find(i => i.UniqueItemId == itemId);
        }
    } 
}