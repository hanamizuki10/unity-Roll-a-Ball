using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 「プレイヤーを追跡するコンポーネントを作る
/*
Playerの位置を取得する
毎フレームPlayerの位置へ座標を調整する
まずはFollowPlayerコンポーネントを作成し、「MainCamera」へ追加します。

HierarchyビューでMainCameraを選択します。
InspectorビューでAdd Componentボタンをクリックします。
「New Script」を選択し、「FollowPlayer」を追加します。
ProjectブラウザでAssets以下のFollowPlayer.csをAssets/Scriptフォルダへ移動します。
*/
public class FollowPlayer : MonoBehaviour
{
  public Transform target; 	// ターゲットへの参照
  private Vector3 offset;		// 相対座標

  // Start is called before the first frame update
  void Start()
  {
    //自分自身とtargetとの相対距離を求める
    offset = GetComponent<Transform>().position - target.position;
  }

  // Update is called once per frame
  void Update()
  {
    // 自分の座標にtargetの座標を代入する
    // 自分自身の座標に、targetの座標に相対座標を足した値を設定する
    GetComponent<Transform>().position = target.position + offset;
  }
}
