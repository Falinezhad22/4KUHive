using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Required for UI

public class ShaderChanger : MonoBehaviour
{
    public Material targetMaterial;  // The material whose shader you want to change
    public Shader shader1;           // First shader
    public Shader shader2;           // Second shader
    public Button changeShaderButton; // UI Button

    private bool isUsingShader1 = true;  // Track which shader is currently applied

    void Start()
    {
        // Assign the Button's onClick event listener
        changeShaderButton.onClick.AddListener(ToggleShader);
    }

    // Method to toggle between the two shaders
    void ToggleShader()
    {
        if (targetMaterial != null && shader1 != null && shader2 != null)
        {
            if (isUsingShader1)
            {
                targetMaterial.shader = shader2;
                Debug.Log("Switched to Shader 2");
            }
            else
            {
                targetMaterial.shader = shader1;
                Debug.Log("Switched to Shader 1");
            }

            // Toggle the flag
            isUsingShader1 = !isUsingShader1;
        }
        else
        {
            Debug.LogWarning("Please assign the material and both shaders in the Inspector.");
        }
    }
}

