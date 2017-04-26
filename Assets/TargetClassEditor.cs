using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



[CustomEditor(typeof(TargetClass))]
public class TargetClassEditor : Editor {
    private void OnSceneGUI()
    {
        TargetClass tc = (TargetClass)target;

        Handles.Label(tc.transform.position + Vector3.up * 2, "Tfloat "+tc.tFloat.ToString());
        float size = HandleUtility.GetHandleSize(tc.transform.position) * .2f;

        tc.tFloat = Handles.Slider(new Vector3(tc.tFloat, tc.transform.position.y, tc.transform.position.z), Vector3.right, size, Handles.ConeHandleCap, .1f).x;


        Handles.color = Color.blue;


        if(Handles.Button(tc.transform.position-Vector3.up*2,Quaternion.identity,size,size,Handles.CubeCap))
        {
            tc.tFloat = 0;


            Handles.Label(tc.transform.position - Vector3.up * 2, "Reset " + tc.tFloat);
        }
    }

    


}
