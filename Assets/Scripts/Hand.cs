using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public int number;

    public GameObject vfxSuccess;
    public GameObject vfxFail;

    private void OnMouseDown()
    {
        if (GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].Remove(this))
        {
            GameObject vfx = Instantiate(vfxSuccess, transform.position, Quaternion.identity);
            Destroy(vfx, 0.75f);
            gameObject.SetActive(false);
        } 
        else
        {
            GameObject vfx = Instantiate(vfxFail, transform.position, Quaternion.identity);
            Destroy(vfx, 0.75f);
        }
    }
}
