using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace OrbitHud
{
    class DisplayItem
    {
        public string label;
        public string value;

        public GUIStyle valueStyle = new GUIStyle();
        public GUIStyle labelStyle = new GUIStyle();

        public DisplayItem (string label)
        {
            this.label = label;

            this.valueStyle.normal.textColor = Color.green;
            this.valueStyle.alignment = TextAnchor.MiddleLeft;
            this.valueStyle.padding.left = 2;

            this.labelStyle.normal.textColor = Color.green;
            this.labelStyle.alignment = TextAnchor.MiddleRight;
        }
    }
}
