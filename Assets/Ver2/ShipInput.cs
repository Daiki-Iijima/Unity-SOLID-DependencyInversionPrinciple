using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ver2 {
    /// <summary>
    /// ‘D‚Ö‚Ì“ü—Í
    /// </summary>
    public class ShipInput : MonoBehaviour {
        public float Rotation { get; private set; }
        public float Thrust { get; private set; }

        private void Update() {
            Rotation = Input.GetAxis("Horizontal");
            Thrust = Input.GetAxis("Vertical");
        }
    }
}
