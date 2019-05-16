using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectorScript : MonoBehaviour
{
    public Animator CabAnim;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(CabStop());
      StartCoroutine(CabGo());
    }

    IEnumerator CabStop()
    {
      yield return new WaitForSeconds(7f);
      CabAnim.SetBool("IsGoing", true);
    }

    IEnumerator CabGo()
    {
      yield return new WaitForSeconds(9.5f);
      CabAnim.SetBool("IsGoing", false);
    }

}//class
