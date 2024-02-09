using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshTrail : MonoBehaviour
{
    public Mesh markerTip;
    private Mesh trueMarkerTip;
    public float markerTipSize;
    public Color highLightColor;
    public float markerDistanceX;
    public float markerDistanceY;
    public float markerDistanceZ;
    private Vector3[] baseVertices;
    private List<List<Matrix4x4>> Marks = new List<List<Matrix4x4>>();
    [Range(1f,100f), Tooltip("The interval between each instance drawn.")] public float weight;
    [Tooltip("The number of instances drawn before they start dissapearing")] public int fadeTime = 1000;
    private float time;
    
    private List<Graphics> drawnMeshes;
    [SerializeField]
    private Material markerMaterial;
    void Start()
    {
        trueMarkerTip = markerTip;
        time = 0f;
    }

    void CreateMark()
    {       
            Marks.Add(new List<Matrix4x4>());
            Vector3 postion = transform.position + new Vector3(markerDistanceX,markerDistanceY,markerDistanceZ);
            Vector3 scale = new Vector3(markerTipSize,markerTipSize,markerTipSize);
            Marks[Marks.Count - 1].Add(Matrix4x4.TRS(postion, Quaternion.identity, scale));
    }

    void removeOldMarks()
    {
        if(Marks.Count > fadeTime)
            Marks.RemoveAt(0);
    }

    void Update()
    {   
        removeOldMarks();
        markerMaterial.color = highLightColor;
        time = time + 1f * Time.deltaTime;
        Vector3 scale = new Vector3(markerTipSize,markerTipSize,markerTipSize);
        if(time >= (.25/weight))
        {
            time = 0f;
            CreateMark();
        }
        DrawMarks();
    }

     private void DrawMarks()
    {   
        foreach (var Mark in Marks)
        {
            for (int i = 0; i < markerTip.subMeshCount; i++)
            {
                Graphics.DrawMeshInstanced(markerTip,i,markerMaterial,Mark);
            }
        }
    }
}
