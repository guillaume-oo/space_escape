// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controllers/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""PlayerMain"",
            ""id"": ""f017c187-2e6c-4d78-a23e-2e4d89401cf0"",
            ""actions"": [
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""b47a809b-a2ce-4f15-9c0d-4e9f82cbf186"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Collect"",
                    ""type"": ""Button"",
                    ""id"": ""932671c3-d531-4887-8451-e74e4748cf80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""dd5aca73-984f-4fb0-a2ae-cbc3356d1337"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""b8793ccb-39ac-4eff-8b5d-5e3829c2d3e8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OpenInventory"",
                    ""type"": ""Button"",
                    ""id"": ""75ef2e84-b5ec-4676-8b2e-207679dde983"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""3ce8cbcf-2731-4a6b-b808-edb9261b8878"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a598a059-59e7-45f7-8f32-7b2b3a125db9"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92479fa5-0c18-4ab6-948f-810440046937"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Collect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbb82239-78b0-4bf2-9d35-c7f23e593140"",
                    ""path"": ""<AndroidGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""52510077-94a0-4314-97a7-bfee24a66fa7"",
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
                    ""id"": ""c8e81d01-9873-48f1-b21f-1fcb704b720d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b3b43845-a5ea-4948-b1e7-44bb2bc68070"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b8f7330b-edb4-44c4-ac04-1dcbe2707b8a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""053472c8-41b2-4281-b513-a086cea1aa75"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a1618a2a-50ad-468d-9871-fd83de43b7e6"",
                    ""path"": ""<AndroidGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1bfb108-f6e0-4d0f-a9f6-15f11d247135"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb4d7bef-edb2-4307-99db-72bf0ae2c09a"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e125ba46-7d53-4275-a774-91ec44740fb2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e40d0185-416e-48c6-8ffd-31ed3510c0d3"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SpaceshipMain"",
            ""id"": ""7de8febc-7be6-43e5-86ed-4150b609d7c3"",
            ""actions"": [
                {
                    ""name"": ""HoverUp"",
                    ""type"": ""Button"",
                    ""id"": ""72b59437-dc3d-4853-b31d-30136279ec67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""af614e6c-f60d-4d92-94b4-6264c6e4a422"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""c73fd7aa-f1df-4f26-b395-124fcc889ef4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""240eaa22-4862-4281-8084-9d202a551c3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HoverDown"",
                    ""type"": ""Button"",
                    ""id"": ""4152c8e1-5307-4249-a5ba-1917409ab027"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""c477557d-85c2-4d23-9293-5bdcec2f7435"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""47f57a5b-c38a-4c50-8cd8-5c6a84f48237"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoverUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""cc173746-97c4-4a7e-a325-40e4630dbfd7"",
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
                    ""id"": ""92892b7a-0708-43d1-8d22-c6b5096c6e01"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2225bcb1-c31b-4997-ba4f-eaaa00729703"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cee77aeb-1c9b-4a34-ad64-08a003c30012"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""da854760-bd3a-40cc-8258-6933b7fbe466"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bcd48678-a627-4cbb-8098-4a487470ce7f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d7205d3-a51c-4f1e-b0ba-c2c8e2e0a650"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoverDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c88974f8-8fcb-42ed-a989-3e4f5af0daad"",
                    ""path"": ""<AndroidGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eaf01a8a-7a7a-4536-b238-708b0472f472"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48f48bbb-d63b-4f90-87ac-ae6f30e48874"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMain
        m_PlayerMain = asset.FindActionMap("PlayerMain", throwIfNotFound: true);
        m_PlayerMain_Use = m_PlayerMain.FindAction("Use", throwIfNotFound: true);
        m_PlayerMain_Collect = m_PlayerMain.FindAction("Collect", throwIfNotFound: true);
        m_PlayerMain_Move = m_PlayerMain.FindAction("Move", throwIfNotFound: true);
        m_PlayerMain_Look = m_PlayerMain.FindAction("Look", throwIfNotFound: true);
        m_PlayerMain_OpenInventory = m_PlayerMain.FindAction("OpenInventory", throwIfNotFound: true);
        m_PlayerMain_Exit = m_PlayerMain.FindAction("Exit", throwIfNotFound: true);
        // SpaceshipMain
        m_SpaceshipMain = asset.FindActionMap("SpaceshipMain", throwIfNotFound: true);
        m_SpaceshipMain_HoverUp = m_SpaceshipMain.FindAction("HoverUp", throwIfNotFound: true);
        m_SpaceshipMain_Look = m_SpaceshipMain.FindAction("Look", throwIfNotFound: true);
        m_SpaceshipMain_Move = m_SpaceshipMain.FindAction("Move", throwIfNotFound: true);
        m_SpaceshipMain_Fire = m_SpaceshipMain.FindAction("Fire", throwIfNotFound: true);
        m_SpaceshipMain_HoverDown = m_SpaceshipMain.FindAction("HoverDown", throwIfNotFound: true);
        m_SpaceshipMain_Use = m_SpaceshipMain.FindAction("Use", throwIfNotFound: true);
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

    // PlayerMain
    private readonly InputActionMap m_PlayerMain;
    private IPlayerMainActions m_PlayerMainActionsCallbackInterface;
    private readonly InputAction m_PlayerMain_Use;
    private readonly InputAction m_PlayerMain_Collect;
    private readonly InputAction m_PlayerMain_Move;
    private readonly InputAction m_PlayerMain_Look;
    private readonly InputAction m_PlayerMain_OpenInventory;
    private readonly InputAction m_PlayerMain_Exit;
    public struct PlayerMainActions
    {
        private @Player m_Wrapper;
        public PlayerMainActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Use => m_Wrapper.m_PlayerMain_Use;
        public InputAction @Collect => m_Wrapper.m_PlayerMain_Collect;
        public InputAction @Move => m_Wrapper.m_PlayerMain_Move;
        public InputAction @Look => m_Wrapper.m_PlayerMain_Look;
        public InputAction @OpenInventory => m_Wrapper.m_PlayerMain_OpenInventory;
        public InputAction @Exit => m_Wrapper.m_PlayerMain_Exit;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMainActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMainActions instance)
        {
            if (m_Wrapper.m_PlayerMainActionsCallbackInterface != null)
            {
                @Use.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnUse;
                @Collect.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnCollect;
                @Collect.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnCollect;
                @Collect.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnCollect;
                @Move.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @OpenInventory.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnOpenInventory;
                @OpenInventory.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnOpenInventory;
                @OpenInventory.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnOpenInventory;
                @Exit.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_PlayerMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @Collect.started += instance.OnCollect;
                @Collect.performed += instance.OnCollect;
                @Collect.canceled += instance.OnCollect;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @OpenInventory.started += instance.OnOpenInventory;
                @OpenInventory.performed += instance.OnOpenInventory;
                @OpenInventory.canceled += instance.OnOpenInventory;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public PlayerMainActions @PlayerMain => new PlayerMainActions(this);

    // SpaceshipMain
    private readonly InputActionMap m_SpaceshipMain;
    private ISpaceshipMainActions m_SpaceshipMainActionsCallbackInterface;
    private readonly InputAction m_SpaceshipMain_HoverUp;
    private readonly InputAction m_SpaceshipMain_Look;
    private readonly InputAction m_SpaceshipMain_Move;
    private readonly InputAction m_SpaceshipMain_Fire;
    private readonly InputAction m_SpaceshipMain_HoverDown;
    private readonly InputAction m_SpaceshipMain_Use;
    public struct SpaceshipMainActions
    {
        private @Player m_Wrapper;
        public SpaceshipMainActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @HoverUp => m_Wrapper.m_SpaceshipMain_HoverUp;
        public InputAction @Look => m_Wrapper.m_SpaceshipMain_Look;
        public InputAction @Move => m_Wrapper.m_SpaceshipMain_Move;
        public InputAction @Fire => m_Wrapper.m_SpaceshipMain_Fire;
        public InputAction @HoverDown => m_Wrapper.m_SpaceshipMain_HoverDown;
        public InputAction @Use => m_Wrapper.m_SpaceshipMain_Use;
        public InputActionMap Get() { return m_Wrapper.m_SpaceshipMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpaceshipMainActions set) { return set.Get(); }
        public void SetCallbacks(ISpaceshipMainActions instance)
        {
            if (m_Wrapper.m_SpaceshipMainActionsCallbackInterface != null)
            {
                @HoverUp.started -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnHoverUp;
                @HoverUp.performed -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnHoverUp;
                @HoverUp.canceled -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnHoverUp;
                @Look.started -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnLook;
                @Move.started -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnMove;
                @Fire.started -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnFire;
                @HoverDown.started -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnHoverDown;
                @HoverDown.performed -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnHoverDown;
                @HoverDown.canceled -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnHoverDown;
                @Use.started -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_SpaceshipMainActionsCallbackInterface.OnUse;
            }
            m_Wrapper.m_SpaceshipMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HoverUp.started += instance.OnHoverUp;
                @HoverUp.performed += instance.OnHoverUp;
                @HoverUp.canceled += instance.OnHoverUp;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @HoverDown.started += instance.OnHoverDown;
                @HoverDown.performed += instance.OnHoverDown;
                @HoverDown.canceled += instance.OnHoverDown;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
            }
        }
    }
    public SpaceshipMainActions @SpaceshipMain => new SpaceshipMainActions(this);
    public interface IPlayerMainActions
    {
        void OnUse(InputAction.CallbackContext context);
        void OnCollect(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnOpenInventory(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
    public interface ISpaceshipMainActions
    {
        void OnHoverUp(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnHoverDown(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
    }
}
