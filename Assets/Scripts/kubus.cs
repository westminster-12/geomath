using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class kubus : MonoBehaviour
{
    public InputField inputSisi;
    public GameObject cube;
    private float valueSisi;
    public GameObject alertMin;
    public GameObject alertMax;


    public void Start()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungVolume = GameObject.Find("hitungVolume").GetComponent<Text>();
        Text hasilVolume = GameObject.Find("hasilVolume").GetComponent<Text>();

        double vS = (cube.transform.localScale.x * 0.1 + 0.7) - 1;

        valueSisi = Convert.ToSingle(vS);

        //valueSisi = cube.transform.localScale.x;
        //valueSisi = cube.transform.localScale.z;
        inputSisi.text = valueSisi.ToString();


        hitungLuas.text = "Luas = 6 * " + valueSisi + "^2 ";
        hasilLuas.text = "Luas = " + Math.Round(6 * (Math.Pow(valueSisi, 2)), 2) + "cm";
        hitungVolume.text = "Volume = " + valueSisi + "*" + valueSisi + "*" + valueSisi;
        hasilVolume.text = "Volume = " + Math.Round((valueSisi * valueSisi * valueSisi), 2) + "cm";
    }


    public void GetInput()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);

        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungVolume = GameObject.Find("hitungVolume").GetComponent<Text>();
        Text hasilVolume = GameObject.Find("hasilVolume").GetComponent<Text>();

        valueSisi = float.Parse(inputSisi.text);
        float valueSisi2 = Convert.ToSingle((valueSisi + 0.3) * 10);
        
        cube.transform.localScale = new Vector3(valueSisi2, valueSisi2, valueSisi2);

        if (valueSisi < 3.29) {
            alertMin.SetActive(true);
        }
        else if (valueSisi > 20)
        {
            alertMax.SetActive(true);
        }
        else
        {
            alertMax.SetActive(false);
            alertMin.SetActive(true);
        }
        hitungLuas.text = "Luas = 6 * " + valueSisi + "^2 ";
        hasilLuas.text = "Luas = " + Math.Round(6 * (Math.Pow(valueSisi, 2)), 2) + "cm";
        hitungVolume.text = "Volume = " + valueSisi + "*" + valueSisi + "*" + valueSisi;
        hasilVolume.text = "Volume = " + Math.Round((valueSisi * valueSisi * valueSisi), 2) + "cm";

    }

}