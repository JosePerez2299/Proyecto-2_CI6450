using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public Vector3 position; // La posición en el mundo
    public List<Edge> edges; // Conexiones a otros nodos

    public Node(Vector3 pos)
    {
        position = pos;
        edges = new List<Edge>();
    }
}

public class Edge
{
    public Node targetNode; // El nodo al que conecta
    public float cost;      // Costo del camino

    public Edge(Node target, float cost)
    {
        targetNode = target;
        this.cost = cost;
    }
}
