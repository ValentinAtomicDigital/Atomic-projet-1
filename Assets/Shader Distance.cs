using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderDistance : MonoBehaviour
{
    public Material ShaderBleu;
    public Transform bouleBleu;
    public Transform bouleBlanche;
    public float newDistanceValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DensityNoise();
        
    }
    void DensityNoise() 
    {
        DistanceCalcul();
        ShaderBleu.SetFloat("_Distance", newDistanceValue);
    }
    float DistanceCalcul()
    {
        newDistanceValue=(1/Vector3.Distance(bouleBlanche.position, bouleBleu.position))*3;
        return newDistanceValue;
    }
}
