using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingManager : MonoBehaviour
{
    public Transform gridCellPrefab;
    public Transform cube;

    public int height;
    public int width;
    private Node[,] nodes;

    void start()
    {
        CreateGrid();
    }

    private void CreateGrid()
    {
        nodes = new Node[width, height];

        var name = 0;

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector3 worldPosition = new Vector3(i, j, 0);
                Transform obj = Instantiate(gridCellPrefab, worldPosition, Quaternion.identity);
                obj.name = "Cell" + name;
                nodes[i,j] = new Node(true, worldPosition, obj);
                name++;
            }
        }
    }



    public class Node
    {
        public bool isPlaceable;
        public Vector3 cellPosition;
        public Transform obj;

        public Node(bool isPlaceable, Vector3 cellPosition, Transform obj)
        {
            this.isPlaceable = isPlaceable;
            this.cellPosition = cellPosition;
            this.obj = obj;
        }
    }
}