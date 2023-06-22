using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class jajarGenjang : MonoBehaviour
{
    public InputField inputTinggi;
    public InputField inputA;
    public InputField inputB;
    public GameObject objJajarGenjang;
    private float valueTinggi;
    private float valueA;
    private float valueB;
    public GameObject alertMin;
    public GameObject alertMax;


    public void Start()
    {
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungKeliling = GameObject.Find("hitungKeliling").GetComponent<Text>();
        Text hasilKeliling = GameObject.Find("hasilKeliling").GetComponent<Text>();

        valueTinggi = 30;
        valueA = 30;
        valueB = 30;
        inputTinggi.text = valueTinggi.ToString();
        inputA.text = valueA.ToString();
        inputB.text = valueB.ToString();

        hitungLuas.text = "Luas = " + valueA + " * " + valueTinggi;
        hasilLuas.text = "Luas = " + valueA * valueTinggi + "cm";
        hitungKeliling.text = "Keliling = 2 * ( " +valueA+ "+" +valueB+ ")";
        hasilKeliling.text = "Keliling = " + 2 * (valueA+valueB) + "cm";
    }
    public void GetInput()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungKeliling = GameObject.Find("hitungKeliling").GetComponent<Text>();
        Text hasilKeliling = GameObject.Find("hasilKeliling").GetComponent<Text>();

        valueTinggi = float.Parse(inputTinggi.text);
        valueA= float.Parse(inputA.text);
        valueB = float.Parse(inputB.text);

        if (valueTinggi < 20 || valueA < 20 || valueB < 20)
        {
            alertMin.SetActive(true);
        }
        else
        {
            alertMin.SetActive(false);
            alertMax.SetActive(false);
            objJajarGenjang.transform.localScale = new Vector3(valueA, valueTinggi, valueB);

            hitungLuas.text = "Luas = " + valueA + " * " + valueTinggi;
            hasilLuas.text = "Luas = " + valueA * valueTinggi + "cm";
            hitungKeliling.text = "Keliling = 2 * ( " + valueA + "+" + valueB + ")";
            hasilKeliling.text = "Keliling = " + 2 * (valueA + valueB) + "cm";
        }


    }

}
