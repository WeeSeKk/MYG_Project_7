using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimatorController : MonoBehaviour
{
    [SerializeField] InputActionProperty triggerAction;
    [SerializeField] InputActionProperty gripAction;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float triggerValue = triggerAction.action.ReadValue<float>();
        float gripValue = gripAction.action.ReadValue<float>();

        animator.SetFloat("Trigger", triggerValue);
        animator.SetFloat("Grip", gripValue);
    }
}