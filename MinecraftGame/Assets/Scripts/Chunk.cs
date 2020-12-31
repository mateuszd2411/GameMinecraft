﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public MeshFilter meshFilter;

    void Start()
    {
        int vertexIndex = 0;
        List<Vector3> vertices = new List<Vector3>();
        List<int> triangles = new List<int>();

        for (int i = 0; i < 6; i++)
        {
            int triangelIndex = VoxelData.voxelTris[0, i];
            vertices.Add(VoxelData.voxelVerts[triangelIndex]);
            triangles.Add(vertexIndex);

            vertexIndex++;
        }

        Mesh mesh = new Mesh();
        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles.ToArray();

        mesh.RecalculateNormals();

        meshFilter.mesh = mesh;
    }

}
