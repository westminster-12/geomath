using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class balok : MonoBehaviour
{
    public InputField inputLebar;
    public InputField inputPanjang;
    public InputField inputTinggi;
    public GameObject cube;
    private float valuePanjang;
    private float valueLebar;
    private float valueTinggi;
    double valueLuas;
    double valueLuas2;
    double valueVolume;
    double valueVolume2;
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

        double vP = (cube.transform.localScale.x * 0.1 * 1.6) - 0.2;
        double vT = (cube.transform.localScale.y * 0.1 * 0.9) - 2;
        double vL = (cube.transform.localScale.z * 0.1 * 0.9) + 0.5;

        valuePanjang = Convert.ToSingle(vP);
        valueTinggi = Convert.ToSingle(vT);
        valueLebar = Convert.ToSingle(vL);

        inputLebar.text = valueLebar.ToString();
        inputPanjang.text = valuePanjang.ToString();
        inputTinggi.text = valueTinggi.ToString();

        valueLuas = 2 * ((valuePanjang * valueLebar) + (valuePanjang * valueTinggi) + (valueLebar * valueTinggi));
        valueLuas2 = Math.Round(valueLuas, 2);
        valueVolume = valueTinggi * valuePanjang * valueLebar;
        valueVolume2 = Math.Round(valueVolume, 2);

        hitungLuas.text = "Luas = 2 ( " + valuePanjang + " * " + valueLebar + "+" + valuePanjang + "*" + valueTinggi + "+" + valueLebar + "*" + valueTinggi + ")";
        hasilLuas.text = "Luas = " + Math.Round(2 * ((valuePanjang * valueLebar) + (valuePanjang * valueTinggi) + (valueLebar * valueTinggi)), 2) + "cm";
        hitungVolume.text = "Volume = " + valuePanjang + "*" + valueLebar + "*" + valueTinggi;
        hasilVolume.text = "Volume = " + Math.Round(valueTinggi * valuePanjang * valueLebar, 2) + "cm";
    }
    public void GetInput()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);

        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungVolume = GameObject.Find("hitungVolume").GetComponent<Text>();
        Text hasilVolume = GameObject.Find("hasilVolume").GetComponent<Text>();
        
        valueLebar = float.Parse(inputLebar.text);
        valuePanjang = float.Parse(inputPanjang.text);
        valueTinggi = float.Parse(inputTinggi.text);

        float valueLebar2 = Convert.ToSingle((valueLebar - 0.5) * 10 / 0.9);
        float valuePanjang2 = Convert.ToSingle((valuePanjang + 0.2) * 10 / 1.6);
        float valueTinggi2 = Convert.ToSingle((valueTinggi + 2) * 10 / 0.9);

        
        if (valuePanjang < 6 || valueLebar < 5.17 || valueTinggi < 2.67)
        {
            alertMin.SetActive(true);
        }
        else if (valuePanjang > 20 || valueLebar > 20 || valueTinggi > 20)
        {
            alertMax.SetActive(true);
        }
        else
        {
            alertMin.SetActive(false);
            alertMax.SetActive(false);
        }

        cube.transform.localScale = new Vector3(valuePanjang2, valueTinggi2, valueLebar2);

        hitungLuas.text = "Luas = 2 ( " + valuePanjang + " * " + valueLebar + "+" + valuePanjang + "*" + valueTinggi + "+" + valueLebar + "*" + valueTinggi + ")";
        hasilLuas.text = "Luas = " + Math.Round(2 * ((valuePanjang * valueLebar) + (valuePanjang * valueTinggi) + (valueLebar * valueTinggi)), 2) + "cm";
        hitungVolume.text = "Volume = " + valuePanjang + "*" + valueLebar + "*" + valueTinggi;
        hasilVolume.text = "Volume = " + Math.Round(valueTinggi * valuePanjang * valueLebar, 2) + "cm";




    }

}