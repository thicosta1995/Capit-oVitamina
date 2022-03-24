using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemControlerScript : MonoBehaviour
{
    [SerializeField] private float H;
    [SerializeField] private float V;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private List<GameObject> armas;
    [SerializeField] private Transform mira;
    [SerializeField] private Rigidbody bala;
    private Ray raio;
    private RaycastHit pontoMira;
    [SerializeField] private Camera camera; 

    
    Vector3 posiçao;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        Movimento();
        Disparar();
        MiraMouse();


    }
     void Movimento()
    {
        H = (Input.GetAxis("Horizontal") * speed) * Time.deltaTime;


        transform.Translate(H, 0, 0);
    }

    void Disparar()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Rigidbody rigidbodyInstace;
            rigidbodyInstace= Instantiate(bala, mira.position, Quaternion.identity)as Rigidbody;
            rigidbodyInstace.AddForce(-500, 0,0) ;
            
        }
    }

    void MiraMouse()
    {
         raio = camera.ScreenPointToRay(Input.mousePosition);
        Vector3 lookAtPosition = armas[0].transform.position;
        lookAtPosition.x = armas[0].transform.position.x;

       bool bloqueado = Physics.Raycast(transform.position, transform.forward, out pontoMira);
        armas[0].transform.LookAt(bloqueado ? pontoMira.point : transform.forward);


    }
}
