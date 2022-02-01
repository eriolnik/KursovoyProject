using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGeneration : MonoBehaviour  // генерация монет закидываем на объект текст!
{

    public float maxPosZ;
    public GameObject[] Variants;
    private string statusActiveVariant = "";
    private string statusTurnOFFVariant = "";
    private int currentVariant;

    private void FixedUpdate()
    {
        if (transform.localPosition != new Vector3(0, 0, 40))
        {
            if (transform.localPosition.z < maxPosZ)
            {
                if (statusActiveVariant == "")
                {
                    currentVariant = Random.Range(0, Variants.Length);
                    Variants[currentVariant].SetActive(true);
                    statusActiveVariant = "Active";
                    statusTurnOFFVariant = "Check";
                }
            }
            else if (transform.localPosition == new Vector3(0, 0, 40))
            {
                if (statusTurnOFFVariant == "Check")
                {
                    Variants[currentVariant].SetActive(false);
                    statusTurnOFFVariant = "";
                    statusActiveVariant = "";
                }
            }
        }
    }
}
