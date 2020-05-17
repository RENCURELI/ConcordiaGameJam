// GENERATED AUTOMATICALLY FROM 'Assets/Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""dfd4a97d-ed70-4496-ba53-de8d73a3ad49"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""8d9eacdd-c1f9-49ab-a526-394e552f579f"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interactions"",
                    ""type"": ""Button"",
                    ""id"": ""90f5d799-3baf-4ca8-8856-5233dab36ba5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LightOrientation"",
                    ""type"": ""Value"",
                    ""id"": ""5a56fc30-1cbd-43b9-99f7-a50286ed5f4d"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LightOn"",
                    ""type"": ""Button"",
                    ""id"": ""6ed13b4f-33e2-4ec8-91cb-e0da422ea4bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ff72ae25-e9ae-4813-92fa-ab7ddc5de300"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interactions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f2252ab-a1a7-4301-92c1-dd0ca517b7db"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7caba2b8-75db-43c6-b7f8-2370b2eead3f"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9947def1-21f5-4a19-9608-541e1cad3030"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        m_Movement_Interactions = m_Movement.FindAction("Interactions", throwIfNotFound: true);
        m_Movement_LightOrientation = m_Movement.FindAction("LightOrientation", throwIfNotFound: true);
        m_Movement_LightOn = m_Movement.FindAction("LightOn", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Move;
    private readonly InputAction m_Movement_Interactions;
    private readonly InputAction m_Movement_LightOrientation;
    private readonly InputAction m_Movement_LightOn;
    public struct MovementActions
    {
        private @Controller m_Wrapper;
        public MovementActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Interactions => m_Wrapper.m_Movement_Interactions;
        public InputAction @LightOrientation => m_Wrapper.m_Movement_LightOrientation;
        public InputAction @LightOn => m_Wrapper.m_Movement_LightOn;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Interactions.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnInteractions;
                @Interactions.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnInteractions;
                @Interactions.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnInteractions;
                @LightOrientation.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLightOrientation;
                @LightOrientation.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLightOrientation;
                @LightOrientation.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLightOrientation;
                @LightOn.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLightOn;
                @LightOn.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLightOn;
                @LightOn.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLightOn;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interactions.started += instance.OnInteractions;
                @Interactions.performed += instance.OnInteractions;
                @Interactions.canceled += instance.OnInteractions;
                @LightOrientation.started += instance.OnLightOrientation;
                @LightOrientation.performed += instance.OnLightOrientation;
                @LightOrientation.canceled += instance.OnLightOrientation;
                @LightOn.started += instance.OnLightOn;
                @LightOn.performed += instance.OnLightOn;
                @LightOn.canceled += instance.OnLightOn;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteractions(InputAction.CallbackContext context);
        void OnLightOrientation(InputAction.CallbackContext context);
        void OnLightOn(InputAction.CallbackContext context);
    }
}
