using UnityEngine;

namespace ItemSystem
{
    [CreateAssetMenu(menuName = "Grid/Item", order = 0)]
    public class Item : ScriptableObject
    {
        public int UniqueItemId;
        public string ItemName;
        public bool IsActive;
        public GameObject ItemPrefab;
    }
}