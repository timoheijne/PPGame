using System;
using Grid;
using UnityEngine;

namespace Input
{
    public class MouseRaycast : MonoBehaviour
    {
        private void Update()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
                
                int layer_mask = LayerMask.GetMask("SelectionLayer");
                if (Physics.Raycast(ray, out hit, 1000, layer_mask)) {
                    Transform objectHit = hit.transform;
                    Debug.Log(objectHit.name);
                    // Do something with the object that was hit by the raycast.

                    GridNode node = objectHit.GetComponent<GridNode>();
                    if (node != null)
                    {
                        // We hit a node boys...
                        node.SetTile(TileType.BaseTile, 1);
                    }
                }
            }
        }
    }
}