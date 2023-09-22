using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Life))]
public class MyLifeEditor : Editor
{
    private Life life;



    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();


        life = (Life)target;

        
        life.useScriptable = EditorGUILayout.Toggle("Use Scriptable?", life.useScriptable);

        if (life.useScriptable)
        {



            life.lifeScriptable = (myScriptableInteger)EditorGUILayout.ObjectField("Life", life.lifeScriptable, typeof(myScriptableInteger), true);

            life.maxLifeScriptable = (myScriptableInteger)EditorGUILayout.ObjectField("Max Life", life.maxLifeScriptable, typeof(myScriptableInteger), true);
        }

        else
        {
            life.life = EditorGUILayout.IntField("Life", life.life);
            life.maxLife = EditorGUILayout.IntField("Max Life", life.maxLife);

        }
    }
}
