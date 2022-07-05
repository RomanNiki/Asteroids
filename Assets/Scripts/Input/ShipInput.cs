//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Input/ShipInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ShipInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ShipInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ShipInput"",
    ""maps"": [
        {
            ""name"": ""Ship"",
            ""id"": ""916acb1c-66b7-4a4b-bd80-bef56da4e3e7"",
            ""actions"": [
                {
                    ""name"": ""MoveForward"",
                    ""type"": ""Button"",
                    ""id"": ""21e27cf6-7353-4d23-8d55-95fc1ebde43c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""77719e56-3999-4bcf-bfc4-2dafaacf2186"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrimiryShoot"",
                    ""type"": ""Button"",
                    ""id"": ""87b1d17e-15d5-43f4-b504-0483e1c1efbc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondaryShoot"",
                    ""type"": ""Button"",
                    ""id"": ""dff86f55-8add-4ab1-b016-e9bc6e8d985b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b19d90cf-56a4-4cd0-a3a3-26274af2b661"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""PrimiryShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""918cdaa0-a508-4b3f-a9cc-40bc881dc297"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Direction"",
                    ""id"": ""bf955a11-0587-4e0d-8418-07bab4db901f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d82fe37c-bea0-4597-b1a5-c81f600d4858"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8745cb8d-0f9c-47a4-80a8-0b1daebe4f45"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""61823de9-1f86-44c7-95b3-b0014797698f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""SecondaryShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_MoveForward = m_Ship.FindAction("MoveForward", throwIfNotFound: true);
        m_Ship_Rotate = m_Ship.FindAction("Rotate", throwIfNotFound: true);
        m_Ship_PrimiryShoot = m_Ship.FindAction("PrimiryShoot", throwIfNotFound: true);
        m_Ship_SecondaryShoot = m_Ship.FindAction("SecondaryShoot", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Ship
    private readonly InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private readonly InputAction m_Ship_MoveForward;
    private readonly InputAction m_Ship_Rotate;
    private readonly InputAction m_Ship_PrimiryShoot;
    private readonly InputAction m_Ship_SecondaryShoot;
    public struct ShipActions
    {
        private @ShipInput m_Wrapper;
        public ShipActions(@ShipInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveForward => m_Wrapper.m_Ship_MoveForward;
        public InputAction @Rotate => m_Wrapper.m_Ship_Rotate;
        public InputAction @PrimiryShoot => m_Wrapper.m_Ship_PrimiryShoot;
        public InputAction @SecondaryShoot => m_Wrapper.m_Ship_SecondaryShoot;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                @MoveForward.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveForward;
                @MoveForward.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveForward;
                @MoveForward.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveForward;
                @Rotate.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @PrimiryShoot.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnPrimiryShoot;
                @PrimiryShoot.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnPrimiryShoot;
                @PrimiryShoot.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnPrimiryShoot;
                @SecondaryShoot.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnSecondaryShoot;
                @SecondaryShoot.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnSecondaryShoot;
                @SecondaryShoot.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnSecondaryShoot;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveForward.started += instance.OnMoveForward;
                @MoveForward.performed += instance.OnMoveForward;
                @MoveForward.canceled += instance.OnMoveForward;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @PrimiryShoot.started += instance.OnPrimiryShoot;
                @PrimiryShoot.performed += instance.OnPrimiryShoot;
                @PrimiryShoot.canceled += instance.OnPrimiryShoot;
                @SecondaryShoot.started += instance.OnSecondaryShoot;
                @SecondaryShoot.performed += instance.OnSecondaryShoot;
                @SecondaryShoot.canceled += instance.OnSecondaryShoot;
            }
        }
    }
    public ShipActions @Ship => new ShipActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IShipActions
    {
        void OnMoveForward(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnPrimiryShoot(InputAction.CallbackContext context);
        void OnSecondaryShoot(InputAction.CallbackContext context);
    }
}