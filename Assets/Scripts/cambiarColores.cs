using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarColores : MonoBehaviour
{
    /*[SerializeField]
	Color cogidoVerde;
	[SerializeField]
	Color colorBad;

    //public float agarrado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SetColor()
	{
		MeshRenderer mr = GetComponent<MeshRenderer>();
		mr.material.color = Color.Lerp(colorBad, cogidoVerde, agarrado);
	}*/
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other) 
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.green;
    }
        
}
