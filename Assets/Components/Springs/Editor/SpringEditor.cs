// ----------------------------------------------------------------------------------------------------------
// Author: Austin Peel
//
// © All rights reserved. ECOLE POLYTECHNIQUE FEDERALE DE LAUSANNE, Switzerland, Section de Physique, 2024.
// See the LICENSE.md file for more details.
// ----------------------------------------------------------------------------------------------------------
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Spring))]
public class SpringEditor : Editor
{
    private Spring spring;

    private void OnEnable()
    {
        spring = target as Spring;
    }

    public override void OnInspectorGUI()
    {
        // Draw the default inspector fields
        DrawDefaultInspector();

        // Check if the any fields have been changed
        if (GUI.changed)
        {
            spring.Redraw();
        }
    }
}
