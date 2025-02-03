using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;

    [SerializeField] private Color[] groundColors;

    private int colorIndex = 0;

    [SerializeField] private float lerpValue;

    [SerializeField] private float time;

    private float currentTime;

    private void Update()
    {
        setColorChangeTime();
        setGroundMaterialSmoothColorChange();
    }

    private void setColorChangeTime()
    {
        if(currentTime <= 0)
        {
            checkColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
        
    }

    private void checkColorIndexValue()
    {
        colorIndex++;

        if(colorIndex >= groundColors.Length)
        {
            colorIndex = 0;
        }
    }

    private void setGroundMaterialSmoothColorChange()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, groundColors[colorIndex], lerpValue * Time.deltaTime);
    }

    private void OnDestroy()
    {
        groundMaterial.color = groundColors[0];
    }

}
