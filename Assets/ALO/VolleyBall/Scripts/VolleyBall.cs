// GENERATED AUTOMATICALLY FROM 'Assets/ALO/VolleyBall/VolleyBall.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VolleyBall : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @VolleyBall()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VolleyBall"",
    ""maps"": [
        {
            ""name"": ""TestWithBall"",
            ""id"": ""07f5a780-2c5e-40f7-854f-b16cb29ca8aa"",
            ""actions"": [
                {
                    ""name"": ""Direction"",
                    ""type"": ""Value"",
                    ""id"": ""6e04dd5e-2a39-4cf1-848e-0647cda5b171"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hit"",
                    ""type"": ""Button"",
                    ""id"": ""a7e09703-3bd2-4df5-a4f8-60946ddee8ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Respawn"",
                    ""type"": ""Button"",
                    ""id"": ""9eea9c52-8736-4f7f-878a-425984d3627e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f150d6bc-d260-4fee-8688-527f378f16da"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1bf93530-5f84-4670-b32a-a831a5912068"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""38c1d80b-7b3a-4bd8-9bfe-659ecc9a2702"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""56412437-fe19-48c4-9deb-a0466427c4f5"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1e386ff6-1608-49d5-9542-9c4f958c759f"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ff1665a2-26ae-461a-8b16-50e261f00c1d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b94efcc7-5fd8-4fb7-9ca3-c8971c67e289"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // TestWithBall
        m_TestWithBall = asset.FindActionMap("TestWithBall", throwIfNotFound: true);
        m_TestWithBall_Direction = m_TestWithBall.FindAction("Direction", throwIfNotFound: true);
        m_TestWithBall_Hit = m_TestWithBall.FindAction("Hit", throwIfNotFound: true);
        m_TestWithBall_Respawn = m_TestWithBall.FindAction("Respawn", throwIfNotFound: true);
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

    // TestWithBall
    private readonly InputActionMap m_TestWithBall;
    private ITestWithBallActions m_TestWithBallActionsCallbackInterface;
    private readonly InputAction m_TestWithBall_Direction;
    private readonly InputAction m_TestWithBall_Hit;
    private readonly InputAction m_TestWithBall_Respawn;
    public struct TestWithBallActions
    {
        private @VolleyBall m_Wrapper;
        public TestWithBallActions(@VolleyBall wrapper) { m_Wrapper = wrapper; }
        public InputAction @Direction => m_Wrapper.m_TestWithBall_Direction;
        public InputAction @Hit => m_Wrapper.m_TestWithBall_Hit;
        public InputAction @Respawn => m_Wrapper.m_TestWithBall_Respawn;
        public InputActionMap Get() { return m_Wrapper.m_TestWithBall; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestWithBallActions set) { return set.Get(); }
        public void SetCallbacks(ITestWithBallActions instance)
        {
            if (m_Wrapper.m_TestWithBallActionsCallbackInterface != null)
            {
                @Direction.started -= m_Wrapper.m_TestWithBallActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_TestWithBallActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_TestWithBallActionsCallbackInterface.OnDirection;
                @Hit.started -= m_Wrapper.m_TestWithBallActionsCallbackInterface.OnHit;
                @Hit.performed -= m_Wrapper.m_TestWithBallActionsCallbackInterface.OnHit;
                @Hit.canceled -= m_Wrapper.m_TestWithBallActionsCallbackInterface.OnHit;
                @Respawn.started -= m_Wrapper.m_TestWithBallActionsCallbackInterface.OnRespawn;
                @Respawn.performed -= m_Wrapper.m_TestWithBallActionsCallbackInterface.OnRespawn;
                @Respawn.canceled -= m_Wrapper.m_TestWithBallActionsCallbackInterface.OnRespawn;
            }
            m_Wrapper.m_TestWithBallActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
                @Hit.started += instance.OnHit;
                @Hit.performed += instance.OnHit;
                @Hit.canceled += instance.OnHit;
                @Respawn.started += instance.OnRespawn;
                @Respawn.performed += instance.OnRespawn;
                @Respawn.canceled += instance.OnRespawn;
            }
        }
    }
    public TestWithBallActions @TestWithBall => new TestWithBallActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface ITestWithBallActions
    {
        void OnDirection(InputAction.CallbackContext context);
        void OnHit(InputAction.CallbackContext context);
        void OnRespawn(InputAction.CallbackContext context);
    }
}
