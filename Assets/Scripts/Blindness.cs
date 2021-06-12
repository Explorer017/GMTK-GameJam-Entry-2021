using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class Blindness : MonoBehaviour
{
    public Light2D light;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        light.pointLightOuterRadius += (float)0.01;
    }
}
