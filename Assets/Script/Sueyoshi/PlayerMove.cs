using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private float PlayerMoveSpeed = 15f;
    private float PlayerJumpPower = 20f;
    private bool JumpFlag = false;
    private bool GetItemFlag = false;
    void Start()
    {
        initialization();
    }
    public void initialization()
    {
        //フラグや変数の初期化を行う
        JumpFlag = false;
        GetItemFlag = false;
    }
    void Update()
    {
        //ジャンプ処理
        if(Input.GetKeyDown(KeyCode.Space) && JumpFlag == true)
        {
            rb.AddForce(Vector3.up * PlayerJumpPower, ForceMode.Impulse);
        }
        
        
    }
    void FixedUpdate()
    {
        //水平入力取得
        float moveX = Input.GetAxis("Horizontal");
        //垂直入力取得
        float moveZ = Input.GetAxis("Vertical");

        //移動量の設定
        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        //Rigidbodyに力を加える
        rb.AddForce(movement * PlayerMoveSpeed);

    }
    
    //当たっているときの処理
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            JumpFlag = true;
        }
        if(collision.gameObject.tag == "Item")
        {
            Destroy(collision.gameObject);
        }
        Debug.Log(GetItemFlag);

    }
    //当たってないときの処理
    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            JumpFlag = false;
        }
        if(collision.gameObject.tag == "Item")
        {
            GetItemFlag = false;
        }
        Debug.Log(GetItemFlag);
    }
}
