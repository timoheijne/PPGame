using System;
using UnityEngine;
using ItemSystem;

namespace Grid
{
    public enum TileType
    {
        BaseTile,
        DecoratorTile,
        ItemTile,
    }
    public class GridNode: MonoBehaviour
    {
        // The following is for serializing and storing grid data
        public int BaseTileId;
        public int DecoratorTileId;
        public int ItemTileId;

        // Following is for the game play
        private GameObject _baseTile;
        private GameObject _decoratorTile;
        private GameObject _itemTile;

        public void SetTile(TileType tileType, int itemID)
        {
            Item item = ItemSystem.ItemSystem.Instance.GetItemByID(itemID);
            if (item == null || item.ItemPrefab == null) return;
            
            switch (tileType)
            {
                case TileType.BaseTile:
                    BaseTileId = itemID;
                    if(_baseTile != null)
                        Destroy(_baseTile);
                    _baseTile = Instantiate(item.ItemPrefab, transform);
                    break;
                case TileType.DecoratorTile:
                    DecoratorTileId = itemID;
                    if(_decoratorTile != null)
                        Destroy(_baseTile);
                    _decoratorTile = Instantiate(item.ItemPrefab, transform);
                    break;
                case TileType.ItemTile:
                    ItemTileId = itemID;
                    if(_itemTile != null)
                        Destroy(_baseTile);
                    _itemTile = Instantiate(item.ItemPrefab, transform);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tileType), tileType, null);
            }
        }
    }
}