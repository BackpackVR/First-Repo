using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaintSplasher : MonoBehaviour
{
    public GameObject splatterPrefab;
    public Transform spawnPos;
    public float speedMultiplier = 0.5f;
    public MeshRenderer tubeMesh;

    public InputActionReference shootInputRef;

    private Color color;

    #region
    private void OnEnable()
    {
        shootInputRef.action.performed += ShootPressed;
    }

    private void OnDisable()
    {
        shootInputRef.action.performed -= ShootPressed;
    }

    private void ShootPressed(InputAction.CallbackContext ctx)
    {
        ShootProjectile();
        
        //Debug.Log("i just shot the painting!");
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        color = Random.ColorHSV(); 
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void ShootProjectile()
    {
        GameObject currentBullet = Instantiate(splatterPrefab, spawnPos.position, Quaternion.identity);

        Rigidbody rb = currentBullet.GetComponent<Rigidbody>();
        MeshRenderer rend = currentBullet.GetComponent<MeshRenderer>();
       
        ChangeTubeMaterial(rend);
        ChangeTubeMaterial(tubeMesh);

        rb.AddForce(spawnPos.forward * speedMultiplier, ForceMode.Impulse);
        
        Destroy(currentBullet, 5f);
       

    }

    void ChangeTubeMaterial(MeshRenderer renderer)
    {
                 
        //Debug.Log(color);
        tubeMesh.material.color = color;
        color = Random.ColorHSV();
    }


}
