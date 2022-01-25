// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/ControlSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlSystem"",
    ""maps"": [
        {
            ""name"": ""TouchScreen"",
            ""id"": ""2d4dc231-6f84-48e7-bc2d-88535ad9b31e"",
            ""actions"": [
                {
                    ""name"": ""click"",
                    ""type"": ""Button"",
                    ""id"": ""8307d61f-522a-4c14-a5b1-2fab37627772"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HoldDirection"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ef5b9b3c-f6b4-4afa-9149-159c85f7ac87"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b6a5ab1a-d35f-493f-bdef-84c1f20e9da5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchPhase"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7a07969c-265c-46c8-b985-7d549505aee4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8c2efcac-fc92-409a-9658-a1d4188ec947"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""TouchSystem"",
                    ""action"": ""click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cd0b2e3-2637-4e07-a516-eb8a57cf4ef0"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": ""Hold,Press"",
                    ""processors"": """",
                    ""groups"": ""TouchSystem"",
                    ""action"": ""HoldDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2665f4e1-4fbf-47ef-a373-3503e9ed4c74"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchSystem"",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91689d24-6382-483e-b8c1-d4cc7a5b1f39"",
                    ""path"": ""<Touchscreen>/primaryTouch/phase"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchSystem"",
                    ""action"": ""TouchPhase"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""TouchSystem"",
            ""bindingGroup"": ""TouchSystem"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // TouchScreen
        m_TouchScreen = asset.FindActionMap("TouchScreen", throwIfNotFound: true);
        m_TouchScreen_click = m_TouchScreen.FindAction("click", throwIfNotFound: true);
        m_TouchScreen_HoldDirection = m_TouchScreen.FindAction("HoldDirection", throwIfNotFound: true);
        m_TouchScreen_TouchPosition = m_TouchScreen.FindAction("TouchPosition", throwIfNotFound: true);
        m_TouchScreen_TouchPhase = m_TouchScreen.FindAction("TouchPhase", throwIfNotFound: true);
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

    // TouchScreen
    private readonly InputActionMap m_TouchScreen;
    private ITouchScreenActions m_TouchScreenActionsCallbackInterface;
    private readonly InputAction m_TouchScreen_click;
    private readonly InputAction m_TouchScreen_HoldDirection;
    private readonly InputAction m_TouchScreen_TouchPosition;
    private readonly InputAction m_TouchScreen_TouchPhase;
    public struct TouchScreenActions
    {
        private @ControlSystem m_Wrapper;
        public TouchScreenActions(@ControlSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @click => m_Wrapper.m_TouchScreen_click;
        public InputAction @HoldDirection => m_Wrapper.m_TouchScreen_HoldDirection;
        public InputAction @TouchPosition => m_Wrapper.m_TouchScreen_TouchPosition;
        public InputAction @TouchPhase => m_Wrapper.m_TouchScreen_TouchPhase;
        public InputActionMap Get() { return m_Wrapper.m_TouchScreen; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchScreenActions set) { return set.Get(); }
        public void SetCallbacks(ITouchScreenActions instance)
        {
            if (m_Wrapper.m_TouchScreenActionsCallbackInterface != null)
            {
                @click.started -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnClick;
                @click.performed -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnClick;
                @click.canceled -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnClick;
                @HoldDirection.started -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnHoldDirection;
                @HoldDirection.performed -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnHoldDirection;
                @HoldDirection.canceled -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnHoldDirection;
                @TouchPosition.started -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnTouchPosition;
                @TouchPhase.started -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnTouchPhase;
                @TouchPhase.performed -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnTouchPhase;
                @TouchPhase.canceled -= m_Wrapper.m_TouchScreenActionsCallbackInterface.OnTouchPhase;
            }
            m_Wrapper.m_TouchScreenActionsCallbackInterface = instance;
            if (instance != null)
            {
                @click.started += instance.OnClick;
                @click.performed += instance.OnClick;
                @click.canceled += instance.OnClick;
                @HoldDirection.started += instance.OnHoldDirection;
                @HoldDirection.performed += instance.OnHoldDirection;
                @HoldDirection.canceled += instance.OnHoldDirection;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
                @TouchPhase.started += instance.OnTouchPhase;
                @TouchPhase.performed += instance.OnTouchPhase;
                @TouchPhase.canceled += instance.OnTouchPhase;
            }
        }
    }
    public TouchScreenActions @TouchScreen => new TouchScreenActions(this);
    private int m_TouchSystemSchemeIndex = -1;
    public InputControlScheme TouchSystemScheme
    {
        get
        {
            if (m_TouchSystemSchemeIndex == -1) m_TouchSystemSchemeIndex = asset.FindControlSchemeIndex("TouchSystem");
            return asset.controlSchemes[m_TouchSystemSchemeIndex];
        }
    }
    public interface ITouchScreenActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnHoldDirection(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
        void OnTouchPhase(InputAction.CallbackContext context);
    }
}
