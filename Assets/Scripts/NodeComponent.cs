using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeComponent : MonoBehaviour
{
    public Node node;

    void Start()
    {
        // Inicializamos el nodo con la posición del GameObject en el mundo
        node = new Node(transform.position);
    }
}
