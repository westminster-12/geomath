using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class lingkaran : MonoBehaviour
{
    public InputField inputRadius;
    public GameObject objLingkaran;
    private float valueRadius;
    public GameObject alert;
    public GameObject alertMin;
    public GameObject alertMax;


    public void Start()
    {
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungKeliling = GameObject.Find("hitungKeliling").GetComponent<Text>();
        Text hasilKeliling = GameObject.Find("hasilKeliling").GetComponent<Text>();

        double vR = (objLingkaran.transform.localScale.x * 0.1 * 0.6 + 0.3)/2;
        float valueRadius = Convert.ToSingle(vR);

        valueRadius = Convert.ToSingle(vR);
        inputRadius.text = valueRadius.ToString();

        hitungLuas.text = "Luas = 3.14 * " + valueRadius + "^2";
        hasilLuas.text = "Luas = " + Math.Round(3.14 * Math.Pow(valueRadius, 2), 2) + "cm";
        hitungKeliling.text = "Keliling = 2 * 3.14 * " + valueRadius;
        hasilKeliling.text = "Keliling = " + Math.Round(2 * 3.14 * valueRadius, 2) + "cm";
    }
    public void GetInput()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);
        alert.SetActive(false);
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungKeliling = GameObject.Find("hitungKeliling").GetComponent<Text>();
        Text hasilKeliling = GameObject.Find("hasilKeliling").GetComponent<Text>();

        valueRadius = float.Parse(inputRadius.text);
        float valueRadius2 = Convert.ToSingle((valueRadius * 2 - 0.3) * 10 / 0.6);
        
        if (valueRadius > 10)
        {
            alertMax.SetActive(true);
        }
        else if (valueRadius < 1.86)
        {
            alertMin.SetActive(true);
        }
        else
        {
        

            alertMin.SetActive(false);
            alertMax.SetActive(false);
            objLingkaran.transform.localScale = new Vector3(valueRadius2, valueRadius2, valueRadius2);

           
        }
        hitungLuas.text = "Luas = 3.14 * " + valueRadius + "^2";
        hasilLuas.text = "Luas = " + Math.Round(3.14 * Math.Pow(valueRadius, 2), 2) + "cm";
        hitungKeliling.text = "Keliling = 2 * 3.14 * " + valueRadius;
        hasilKeliling.text = "Keliling = " + Math.Round(2 * 3.14 * valueRadius, 2) + "cm";

    }
}
