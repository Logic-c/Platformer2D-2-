// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""playercontrol"",
            ""id"": ""8ef887a1-e52a-475a-bc09-6d9f24dbb764"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""7d0503c7-d01b-493c-aef5-93bb09621ba6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8b8d5b9a-fbbe-48cd-9ed8-3a29545c46a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Schoot"",
                    ""type"": ""Button"",
                    ""id"": ""f443741e-188f-4b02-9a70-0e71248572cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f21d290d-e7b7-425a-b0ff-fa93c53995b2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f3e7aebb-9821-4347-9660-e4895adfd327"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cdc8ac48-fea3-402e-a003-18237bf55194"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""97b2722d-960b-4261-9a62-d74010af2997"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6b0475b9-d41a-4554-a35b-c8a2a0a28f76"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8c5e7725-f3bb-42c2-87eb-2dcdeb3ca138"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c93fdd5d-c388-4fee-9d64-d76acf1a3691"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Schoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // playercontrol
        m_playercontrol = asset.FindActionMap("playercontrol", throwIfNotFound: true);
        m_playercontrol_Move = m_playercontrol.FindAction("Move", throwIfNotFound: true);
        m_playercontrol_Jump = m_playercontrol.FindAction("Jump", throwIfNotFound: true);
        m_playercontrol_Schoot = m_playercontrol.FindAction("Schoot", throwIfNotFound: true);
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

    // playercontrol
    private readonly InputActionMap m_playercontrol;
    private IPlayercontrolActions m_PlayercontrolActionsCallbackInterface;
    private readonly InputAction m_playercontrol_Move;
    private readonly InputAction m_playercontrol_Jump;
    private readonly InputAction m_playercontrol_Schoot;
    public struct PlayercontrolActions
    {
        private @Controls m_Wrapper;
        public PlayercontrolActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_playercontrol_Move;
        public InputAction @Jump => m_Wrapper.m_playercontrol_Jump;
        public InputAction @Schoot => m_Wrapper.m_playercontrol_Schoot;
        public InputActionMap Get() { return m_Wrapper.m_playercontrol; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayercontrolActions set) { return set.Get(); }
        public void SetCallbacks(IPlayercontrolActions instance)
        {
            if (m_Wrapper.m_PlayercontrolActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnJump;
                @Schoot.started -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnSchoot;
                @Schoot.performed -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnSchoot;
                @Schoot.canceled -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnSchoot;
            }
            m_Wrapper.m_PlayercontrolActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Schoot.started += instance.OnSchoot;
                @Schoot.performed += instance.OnSchoot;
                @Schoot.canceled += instance.OnSchoot;
            }
        }
    }
    public PlayercontrolActions @playercontrol => new PlayercontrolActions(this);
    public interface IPlayercontrolActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSchoot(InputAction.CallbackContext context);
    }
}
