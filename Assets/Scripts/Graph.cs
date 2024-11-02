using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public List<Node> nodes;

    public Graph()
    {
        nodes = new List<Node>();
    }

    public void AddNode(Node node)
    {
        nodes.Add(node);
    }

    public void ConnectNodes(Node from, Node to, float cost)
    {
        from.edges.Add(new Edge(to, cost));
        to.edges.Add(new Edge(from, cost)); // Si la conexión es bidireccional
    }
}


