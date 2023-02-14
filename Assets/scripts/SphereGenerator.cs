using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SphereGenerator : MonoBehaviour{
    Mesh mesh;

    Vector3[] vertices;
    int[] triagles;

    void Start(){
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
    }

    void CreateShape(){

    }

    
}
