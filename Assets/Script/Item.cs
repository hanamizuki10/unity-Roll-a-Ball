﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
  // トリガーとの接触時に呼ばれるコールバック
  void OnTriggerEnter (Collider hit)
  {
    // 接触対象はPlayerタグですか？
    if (hit.CompareTag ("Player")) {
      // 何らかの処理
      // このコンポーネントを持つGameObjectを破棄する
      Destroy(gameObject);
    }
  }
}