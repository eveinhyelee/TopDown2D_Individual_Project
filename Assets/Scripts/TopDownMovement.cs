using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //������ �̵��� �Ͼ ������Ʈ

    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    private Vector2 movementDirection = Vector2.zero;

    void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        controller.OnMoveEvent += Move;    
    }

    /*������Ʈ �����ӱ���ε�, ������� FixedUpdate���� ����ϱ�����
    ApplyMovement�� ����� �־���.*/
    private void Move(Vector2 direction) 
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}
