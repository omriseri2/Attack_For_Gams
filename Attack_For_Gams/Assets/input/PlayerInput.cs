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
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""5821fb78-df6b-49f1-ad36-e21d727b2424"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""79a7f8b9-fdfe-4efd-be21-d0b30b57f775"",
                    ""path"": ""<Gamepad>/leftStick"",
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
                    ""id"": ""a65443cf-a15a-4e1f-b458-e0fd6f7240a9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3395055f-a87b-46af-9696-2eeb0bf47054"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
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
        m_characterControler_jump = m_characterControler.FindAction("jump", throwIfNotFound: true);
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
    private readonly InputAction m_characterControler_jump;
    public struct CharacterControlerActions
    {
        private @PlayerInput m_Wrapper;
        public CharacterControlerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_characterControler_move;
        public InputAction @jump => m_Wrapper.m_characterControler_jump;
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
                @jump.started -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_CharacterControlerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_CharacterControlerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
            }
        }
    }
    public CharacterControlerActions @characterControler => new CharacterControlerActions(this);
    public interface ICharacterControlerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
