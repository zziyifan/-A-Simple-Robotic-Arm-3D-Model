using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderControl : MonoBehaviour
{
    public Slider[] sliders;
    public GameObject[] joints;
    public TextMeshProUGUI[] values;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int i = -1;
        joints[++i].transform.localEulerAngles = new Vector3(0f,sliders[i].value,0f); //y
        values[i].text = sliders[i].value.ToString("0");

        joints[++i].transform.localEulerAngles = new Vector3(0f,0f,sliders[i].value); //z
        values[i].text = sliders[i].value.ToString("0");

        joints[++i].transform.localEulerAngles = new Vector3(0f,0f,sliders[i].value); //z
        values[i].text = sliders[i].value.ToString("0");

        joints[++i].transform.localEulerAngles = new Vector3(sliders[i].value,0f,0f);  //x
        values[i].text = sliders[i].value.ToString("0");

        joints[++i].transform.localEulerAngles = new Vector3(0f,0f,sliders[i].value);  // z
        values[i].text = sliders[i].value.ToString("0");

        joints[++i].transform.localEulerAngles = new Vector3(sliders[i].value,0f,0f);   //x
        values[i].text = sliders[i].value.ToString("0");
    }
}
