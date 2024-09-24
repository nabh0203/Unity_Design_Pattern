using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/*������ ���� ����  : ���� å�� ��Ģ*/
public class UnrefactoredPlayer : MonoBehaviour
{
    
    /*
        [SerializeField] private string inputAxisName; 
        [SerializeField] private float positionMultiplier;
        private float yPosition;
        private AudioSource bounceSfx;

        private void Start()
        {
             bounceSfx = GetComponent<AudioSource>();
        }
        private void Update()
        {

            float delta  =  Input.GetAxis(inputAxisName) * Time.deltaTime;

            yPosition = Mathf.Clamp(yPosition + delta, -1, 1);  

            transform.position = new Vector3(transform.position.x, yPosition * positionMultiplier, transform.position.z);
        }
        private void OnTriggerEnter(Collider other)
        {
            bounceSfx.Play();
        }

        - ���� ����å���� �����ϰ� Ŀ���� ������Ʈ�� �ۼ��� ���� -

        * ���⼭ ����å���̶� ? *
        SRP(���� å�� ��Ģ)��, ���, Ŭ���� �Ǵ� �Լ��� ���� �� ������ å������ ������ Ư�� �κи� ĸ��ȭ�� ���� ���
    */


    //[RequireComponen(typeof(Calss Name))]  - �Լ� �ۼ���
    //����Ƽ C#���� ���Ǵ� ��Ʈ����Ʈ�ν� �Ʒ��� ��õ� Ư�� ��ũ��Ʈ�� �ʿ��� ������Ʈ���� �ڵ����� �߰��ϵ��� �����Ѵ�.

    [RequireComponent(typeof(PlayerAudio), typeof(PlayerInput),typeof(PlayerMovement))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerAudio playerAudio;
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private PlayerMovement playerMovement;
        string startMessege;
        private void Start()
        {
            playerAudio = GetComponent<PlayerAudio>();
            playerInput = GetComponent<PlayerInput>();
            playerMovement = GetComponent<PlayerMovement>();
        }
    }
    public class PlayerAudio : MonoBehaviour
    {
        
    }
    public class PlayerInput : MonoBehaviour
    {

    }
    public class PlayerMovement : MonoBehaviour
    {
        
    }
    /*
        ��ó�� Player ��ũ��Ʈ�� ������ ��ũ���õ� �ٸ� ������Ʈ�� ������ �� �ְ� �ϸ鼭 �� Ŭ������ ���� �� ���� ���Ҹ� �����ϴ�. 
        �̷��� �������ϸ� �ڵ带 �� ���� ������ �� �ְ�, Ư�� �ð��� ������ ������Ʈ �䱸 ������ �ٲ�� ��Ȳ������ ���� �����ϴ�.

        * �߿��� * 
        ������ �̷��� ���� å�� ��Ģ�� ��Ű�� ��ũ��Ʈ��� �ص� �մ��� ��ļ������� �����ؾ� �Ѵ�.
        �ϳ��� �޼��常���� Ŭ������ ����� �ش����� ����ȭ�� ���ؾ� �Ѵ�.

        �׸��Ͽ� å�� ��Ģ�� ���� �۾��� �� ���ο� �� ���� ��ǥ�δ� 

        1. ������:Ŭ������ ª���� �б� ����� �����ϰ� �������� ��Ģ�� ������ ���� �����ڰ� ������ ���� 200~300�� ������ �����Ѵ�.
        ���� �Ǵ� �� �������� ��� ������ ª�ٰ� �������� ��Ģ�� ���� �� ������ �ѵ��� �ʰ��ϸ� �� �۰� �����͸��� ������ �����ؾ� �Ѵ�.

        2. Ȯ�强: ���� Ŭ�������� ����ϱⰡ �� ����, �ǵ�ġ ���� ��� ��ָ� ������ �ʿ� ���� Ŭ������ �����ϰų� ��ü�ؾ��Ѵ�.
        
        3. ���뼺: ������ �ٸ� �κп� ������ �� �ֵ��� Ŭ������ ���� ��������� �������ؾ� �Ѵ�.
    */
}
