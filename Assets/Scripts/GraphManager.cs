using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphManager : MonoBehaviour
{
    public Graph graph;
    public bool draw = false;

    void Start()
    {
        graph = gameObject.AddComponent<Graph>();

        // Encuentra todos los GameObjects que tienen el componente NodeComponent
        NodeComponent[] nodeComponents = FindObjectsOfType<NodeComponent>();

        // Agrega cada nodo al grafo
        foreach (var nodeComponent in nodeComponents)
        {
            Debug.Log(nodeComponent);
            graph.AddNode(nodeComponent.node);
        }

        // Conecta los nodos entre sí (esto lo debes personalizar según tu mapa)
        // Por ejemplo, podrías conectar nodos cercanos o adyacentes.
        ConnectZones();


    }

    void ConnectZones()
    {
        // Aquí puedes conectar los nodos como desees.
        // Ejemplo: conecta los nodos si están a menos de una cierta distancia:
        foreach (var nodeA in graph.nodes)
        {
            foreach (var nodeB in graph.nodes)
            {
                if (nodeA != nodeB && Vector3.Distance(nodeA.position, nodeB.position) < 5f)
                {
                    graph.ConnectNodes(nodeA, nodeB, Vector3.Distance(nodeA.position, nodeB.position));
                }
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        if (graph == null) return;

        foreach (var node in graph.nodes)
        {
            foreach (var edge in node.edges)
            {
                Gizmos.DrawLine(node.position, edge.targetNode.position);
            }
        }
    }

}
