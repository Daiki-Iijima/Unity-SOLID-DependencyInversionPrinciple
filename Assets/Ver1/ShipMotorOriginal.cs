using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver1 {
    public class ShipMotorOriginal : MonoBehaviour {
        [SerializeField] private float turnSpeed = 15f;
        [SerializeField] private float moveSpeed = 10f;

        private void Update() {
            //  ���͂̎󂯎�肪�AInput�N���X�Ɉˑ����Ă���
            //  ���[�U�[�̓��͂����󂯕t���Ȃ�
            float rotation = Input.GetAxis("Horizontal");
            float thrust = Input.GetAxis("Vertical");

            //  ��]
            transform.Rotate(Vector3.up * rotation * Time.deltaTime * turnSpeed);
            //  �O�i
            transform.position += transform.forward * thrust * Time.deltaTime * moveSpeed;
        }
    }
}
