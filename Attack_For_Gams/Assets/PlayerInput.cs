// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""characterControler"",
            ""id"": ""c6c7dba0-c456-4b84-825e-06a994fb2136"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""d1ea47f5-c7d9-403a-a8d3-721511481c5f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookX"",
                    ""type"": ""Value"",
                    ""id"": ""fc450994-891f-4506-9c53-ec3a1c3109d2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookY"",
                    ""type"": ""Value"",
                    ""id"": ""957c5856-6f57-482b-854e-aafedfaeec46"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""79a7f8b9-fdfe-4efd-be21-d0b30b57f775"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e81f4a38-ec4c-4971-b5bd-4907c283e4be"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""64ab027c-4210-4da7-b7b9-8313a677199d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2ac909f6-dc92-48d6-a5d1-cc5b73840a62"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""080a8c68-7b02-48bf-b167-4729132215ca"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dd2965ef-36a0-4880-8280-61d4a5406f17"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7015f452-3981-4f20-b491-6872eca175b7"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55572d80-d0cb-4cdf-bede-50683179c430"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8b2173f-6445-44ed-bb30-18881313c049"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7de7678-75f0-4ece-bac9-6d10b0577783"",
                    ""path"": ""<Mouse>/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // characterControler
        m_characterControler = asset.FindActionMap("characterControler", throwIfNotFound: true);
        m_characterControler_move = m_characterControler.FindAction("move", throwIfNotFound: true);
        m_characterControler_LookX = m_characterControler.FindAction("LookX", throwIfNotFound: true);
        m_characterControler_LookY = m_characterControler.FindAction("LookY", throwIfNotFound: true);
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

    // characterControler
    private readonly InputActionMap m_characterControler;
    private ICharacterControlerActions m_CharacterControlerActionsCallbackInterface;
    private readonly InputAction m_characterControler_move;
    private readonly InputAction m_characterControler_LookX;
    private readonly InputAction m_characterControler_LookY;
    public struct CharacterControlerActions
    {
        private @PlayerInput m_Wrapper;
        public CharacterControlerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_characterControler_move;
        public InputAction @LookX => m_Wrapper.m_characterControler_LookX;
        public InputAction @LookY => m_Wrapper.m_characterControler_LookY;
        public InputActionMap Get() { return m_Wrapper.m_characterControler; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlerActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControlerActions instance)
        {
            if (m_Wrapper.m_CharacterControlerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnMove;
                @LookX.started -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnLookX;
                @LookX.performed -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnLookX;
                @LookX.canceled -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnLookX;
                @LookY.started -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnLookY;
                @LookY.performed -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnLookY;
                @LookY.canceled -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnLookY;
            }
            m_Wrapper.m_CharacterControlerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @LookX.started += instance.OnLookX;
                @LookX.performed += instance.OnLookX;
                @LookX.canceled += instance.OnLookX;
                @LookY.started += instance.OnLookY;
                @LookY.performed += instance.OnLookY;
                @LookY.canceled += instance.OnLookY;
            }
        }
    }
    public CharacterControlerActions @characterControler => new CharacterControlerActions(this);
    public interface ICharacterControlerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLookX(InputAction.CallbackContext context);
        void OnLookY(InputAction.CallbackContext context);
    }
}
