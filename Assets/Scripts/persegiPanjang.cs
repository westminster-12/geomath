using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class persegiPanjang : MonoBehaviour
{
    public InputField inputLebar;
    public InputField inputPanjang;
    public GameObject persegi_panjang;
    private float valuePanjang;
    private float valueLebar;
    public GameObject alert;
    public GameObject alertMin;
    public GameObject alertMax;


    public void Start()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);

        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungKeliling = GameObject.Find("hitungKeliling").GetComponent<Text>();
        Text hasilKeliling = GameObject.Find("hasilKeliling").GetComponent<Text>();

        double vP = (persegi_panjang.transform.localScale.x * 0.01 * 0.7) - 0.4;
        double vL = (persegi_panjang.transform.localScale.y * 0.01 * 0.7) - 0.3;

        valuePanjang = Convert.ToSingle(Math.Round(vP, 2));
        valueLebar = Convert.ToSingle(Math.Round(vL, 2));

        inputLebar.text = valueLebar.ToString();
        inputPanjang.text = valuePanjang.ToString();


        hitungLuas.text = "Luas = " + valueLebar + " * " + valuePanjang;
        hasilLuas.text = "Luas = " + Math.Round(valuePanjang * valueLebar, 2) + "cm";
        hitungKeliling.text = "Keliling = 2 (" + valueLebar + " + " + valuePanjang + ")";
        hasilKeliling.text = "Keliling = " + Math.Round(2 * (valueLebar + valuePanjang), 2) + "cm";
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

        valueLebar = float.Parse(inputLebar.text);
        valuePanjang = float.Parse(inputPanjang.text);

        float valueLebar2 = Convert.ToSingle((valueLebar + 0.3) * 100 / 0.7);
        float valuePanjang2 = Convert.ToSingle((valuePanjang + 0.4) * 100 / 0.7);

        if (valuePanjang < 4.32 || valueLebar < 3.02)
        {
            alertMin.SetActive(true);
        }
        else if (valuePanjang > 20 || valueLebar > 20)
        {
            alertMax.SetActive(true);
        }
        else
        {
            alertMin.SetActive(false);
            alertMax.SetActive(false);
            if (valueLebar == valuePanjang) {
                alert.SetActive(true);
            }
        }
        persegi_panjang.transform.localScale = new Vector3(valuePanjang2, valueLebar2, valueLebar2);

        hitungLuas.text = "Luas = " + valueLebar + " * " + valuePanjang;
        hasilLuas.text = "Luas = " + Math.Round(valuePanjang * valueLebar, 2) + "cm";
        hitungKeliling.text = "Keliling = 2 (" + valueLebar + " + " + valuePanjang + ")";
        hasilKeliling.text = "Keliling = " + Math.Round(2 * (valueLebar + valuePanjang), 2) + "cm";


    }

}
