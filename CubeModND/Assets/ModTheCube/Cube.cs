using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    public MeshRenderer renderer;
    public float rotationMin = 10;
    public float rotationMax = 360;
    private float rotationSpeedX = 0;
    private float rotationSpeedY = 0;
    private float rotationSpeedZ = 0;
    private float colorRed;
    private float colorBlue;
    private float colorGreen;
    //public private colorYellow;
    public float colorScaleMin = 0.0f;
    public float colorScaleMax = 1.0f;
    public float cubeScaleMin = 0.0f;
    public float cubeScaleMax = 5.0f;
    private float newScale;
    private float positionX;
    private float positionY;
    private float positionZ;
    public float positionXMin = 0.0f;
    public float positionXMax = 0.0f;
    public float positionYMin = 0.0f;
    public float positionYMax = 0.0f; 
    public float positionZMin = 0.0f;
    public float positionZMax = 0.0f;
    //public Material cubeMaterial;
    public Color newCubeColor;
    [Range(0, 2)] public float lerptTime;
    void Start()
    {
        //transform.position = new Vector3(3, 4, 1);
        //cubeScaleRange = Random.Range(0, );
        //transform.localScale = Vector3.one * cubeScaleRange;
        InvokeRepeating("ScaleChanger", 0, 2.0f);
        InvokeRepeating("CubeRotation", 0, 2.0f);
        InvokeRepeating("ColorChanger", 0, 2.0f);
        InvokeRepeating("PositionChanger", 0, 2.0f);

        //Material material = Renderer.material;

        //material.color = new Color(colorRed, rotationSpeedY, rotationSpeedX, 0.4f);
        //material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

        //renderer.GetComponent<MeshRenderer>();    
    }
    
    void Update()
    {
        transform.Rotate(rotationSpeedX * Time.deltaTime, rotationSpeedY * Time.deltaTime, rotationSpeedZ * Time.deltaTime);
        
        //Material cubeMaterial = renderer.material;
        renderer.material.color = Color.Lerp(renderer.material.color, newCubeColor, lerptTime * Time.deltaTime);

        transform.position = new Vector3(positionX, positionY, positionZ);

    }

    public void ScaleChanger()
    {
        newScale = Random.Range(cubeScaleMin, cubeScaleMax);
        transform.localScale = Vector3.one * newScale;
        Debug.Log("test");
    }

    public void CubeRotation()
    {
        rotationSpeedX = Random.Range(rotationMin, rotationMax);
        rotationSpeedY = Random.Range(rotationMin, rotationMax);
        rotationSpeedZ = Random.Range(rotationMin, rotationMax);
    }

    public void ColorChanger()
    {
        colorRed = Random.Range(colorScaleMin, colorScaleMax);
        colorBlue = Random.Range(colorScaleMin, colorScaleMax);
        colorGreen = Random.Range(colorScaleMin, colorScaleMax);
        newCubeColor = new Color(colorRed, colorGreen, colorBlue);
        //cubeMaterial.DOColor(colorRed, 2.0f);
    }

    public void OpacityChanger()
    {
        colorRed = Random.Range(colorScaleMin, colorScaleMax);
        colorBlue = Random.Range(colorScaleMin, colorScaleMax);
        colorGreen = Random.Range(colorScaleMin, colorScaleMax);
        //colorYellow = Random.Range(colorScaleMin, colorScaleMax);
    }

    public void PositionChanger()
    {
        positionX = Random.Range(positionXMin, positionXMax);
        positionY = Random.Range(positionYMin, positionYMax);
        positionZ = Random.Range(positionZMin, positionZMax);
    }
}
