﻿using System;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace QMFreeze.Components
{
    // Stolen from knah
    // https://github.com/knah/VRCMods/blob/326b5f6d3d1c4bc3474b3518938d49efb918c1d8/UIExpansionKit/Components/EnableDisableListener.cs
    public class EnableDisableListener : MonoBehaviour
    {
#nullable enable

        [method: HideFromIl2Cpp]
        public event Action? OnEnabled;

        [method: HideFromIl2Cpp]
        public event Action? OnDisabled;

#nullable disable

        public EnableDisableListener(IntPtr obj0) : base(obj0)
        {
        }

        private void OnEnable()
        {
            OnEnabled?.Invoke();
        }

        private void OnDisable()
        {
            OnDisabled?.Invoke();
        }
    }
}