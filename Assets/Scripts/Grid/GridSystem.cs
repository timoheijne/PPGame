using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

namespace Grid
{
    public class GridSystem : MonoBehaviour
    {
        [Tooltip("Define the size of the grid, X*Y")]
        public Vector2Int GridSize;

        [Tooltip("Define the size of each tile in unity units")]
        public Vector2 TileSize = new Vector2(1, 1);

        [Tooltip("The base node every node should have")]
        public GameObject NodePrefab;
        
        private GridNode[,] _grid;
        

        // Start is called before the first frame update
        void Start()
        {
            // Initialize grid with grid size
            
            fillGrid();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void fillGrid()
        {
            _grid = new GridNode[GridSize.x, GridSize.y];

            for (int i = 0; i < GridSize.x; i++)
            {
                for (int j = 0; j <  GridSize.y; j++)
                {
                    GameObject go = Instantiate(NodePrefab, transform);
                    go.gameObject.name = $"Node {i}x{j}";
                    go.transform.position = new Vector3(TileSize.x * i,0,TileSize.y * j);
                    
                    GridNode node = go.GetComponent<GridNode>();
                    node.SetTile(TileType.BaseTile, node.BaseTileId);
                    _grid[i, j] = node;
                }
            }
        }
    }
}
