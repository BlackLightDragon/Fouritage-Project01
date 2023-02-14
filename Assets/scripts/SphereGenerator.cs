using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SphereGenerator : MonoBehaviour{
    Mesh mesh;

    int radius;
    int fractions;

    void Start(){
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        Vector3[] vertices;
        int[] triagles;
        //CreateShape();
    }

    void CreateSubdivTriange(Vector3 point1, Vector3 point2, Vector3 point3, int frac)
    {
        // need reliability tryout
        var all_vertex = new List<Vector3>();
        var prev_vertex = new List<Vector3>();
        var working_vertex = new List<Vector3>();

        Vector3 dst = point2 - point1 * 1/frac; // from p1 to p2
        Vector3 dst2 = point3 - point1 * 1 / frac;

        for (int i = 0; i < frac; i++)
        {   // loop for Layer specified by frac
            for (int i2 = 0; i2 < prev_vertex.Count; i++)
            {   // loop for new Vertecies in Layer
                Vector3 v = prev_vertex[i2] + dst;
                working_vertex.Add(v);
            }
            working_vertex.Add(prev_vertex[-1] + dst2);
            prev_vertex = working_vertex;
            
            foreach (var item in working_vertex)
            {
                all_vertex.Add(item);
            }
            working_vertex = new List<Vector3>();
        }

        // Convert Vertex to triagles

    }


    void SphereFromTriagle(Vector3 center, int radius)
    {
        // p1, p2, p3, p4
    }
    
}
