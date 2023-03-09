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
        Debug.Log("i just shot the paintting!");
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootProjectile()
    {
        GameObject currentBullet = Instantiate(splatterPrefab, transform.position, Quaternion.identity);

        Rigidbody rb = currentBullet.GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * speedMultiplier, ForceMode.Impulse);
        

        ChangeTubeMaterial();

        Destroy(currentBullet, 6f);

    }

    void ChangeTubeMaterial()
    {
        Color randomRGB = new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
         
        tubeMesh.material.color = randomRGB;
    }
}
