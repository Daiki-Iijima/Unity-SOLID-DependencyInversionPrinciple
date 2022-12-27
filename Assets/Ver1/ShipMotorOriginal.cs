using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver1 {
    public class ShipMotorOriginal : MonoBehaviour {
        [SerializeField] private float turnSpeed = 15f;
        [SerializeField] private float moveSpeed = 10f;

        private void Update() {
            //  入力の受け取りが、Inputクラスに依存している
            //  ユーザーの入力しか受け付けない
            float rotation = Input.GetAxis("Horizontal");
            float thrust = Input.GetAxis("Vertical");

            //  回転
            transform.Rotate(Vector3.up * rotation * Time.deltaTime * turnSpeed);
            //  前進
            transform.position += transform.forward * thrust * Time.deltaTime * moveSpeed;
        }
    }
}
