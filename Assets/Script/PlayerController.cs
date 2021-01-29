using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  //「ボタンを押したら転がる」機能
  // 毎フレーム入力を受け付ける
  // 物理演算前で動く前に、入力内容を元にプレイヤーのrigidbody（剛体）に力を加える

  // speedを制御する
  public float speed = 10;


  // FixedUpdate:物理演算でキャラクターが動く度に呼ばれる処理を設定
  void FixedUpdate ()
  {
    //  入力をxとzに代入
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");

    // 同一のGameObjectが持つRigidbodyコンポーネントを取得
    Rigidbody rigidbody = GetComponent<Rigidbody>();

    // rigidbodyのx軸（横）とz軸（奥）に力を加える
    // xとzに10をかけて押す力をアップ
    rigidbody.AddForce(x * speed , 0, z * speed);
  }

}
