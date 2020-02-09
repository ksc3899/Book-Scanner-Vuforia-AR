using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCanvasStatus : MonoBehaviour
{
    public GameObject markerNotFound;
    public GameObject markerFound;
    public GameObject scanner;

    public void OnDetected()
    {
        StartCoroutine("TargetImageDetected");
    }

    public void OnLost()
    {
        StopCoroutine("TargetImageDetected");
        scanner.SetActive(false);
        markerFound.SetActive(false);
        markerNotFound.SetActive(true);
    }

    private IEnumerator TargetImageDetected()
    {
        scanner.SetActive(true);
        yield return new WaitForSeconds(2f);
        scanner.SetActive(false);
        markerNotFound.SetActive(false);
        markerFound.SetActive(true);
    }
}
