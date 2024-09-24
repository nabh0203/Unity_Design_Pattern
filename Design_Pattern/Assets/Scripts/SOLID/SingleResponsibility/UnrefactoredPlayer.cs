using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/*디자인 패턴 공부  : 단일 책임 원칙*/
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

        - 위는 단일책임을 무시하고 커스텀 컴포넌트를 작성한 예시 -

        * 여기서 단일책임이란 ? *
        SRP(단일 책임 원칙)로, 모듈, 클래스 또는 함수가 오직 한 가지만 책임지며 로직의 특정 부분만 캡슐화할 것을 명시
    */


    //[RequireComponen(typeof(Calss Name))]  - 함수 작성법
    //유니티 C#에서 사용되는 어트리뷰트로써 아래에 명시된 특정 스크립트가 필요한 컴포넌트들을 자동으로 추가하도록 유도한다.

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
        위처럼 Player 스크립트가 여전히 스크립팅된 다른 컴포넌트를 관리할 수 있게 하면서 각 클래스는 오직 한 가지 역할만 수행하다. 
        이렇게 디자인하면 코드를 더 쉽게 수정할 수 있고, 특히 시간이 지나며 프로젝트 요구 사항이 바뀌는 상황에서는 더욱 유용하다.

        * 중요점 * 
        하지만 이러한 단일 책임 원칙을 지키는 스크립트라고 해도 합당한 상식선에서만 적용해야 한다.
        하나의 메서드만으로 클래스를 만드는 극단적인 간소화는 피해야 한다.

        그리하여 책임 원칙을 따라 작업할 때 염두에 둘 만한 목표로는 

        1. 가독성:클래스가 짧으면 읽기 쉬우며 엄격하고 직관적인 규칙은 없지만 많은 개발자가 라인의 수를 200~300개 정도로 제한한다.
        본인 또는 팀 차원에서 어느 정도를 짧다고 규정할지 원칙을 정한 뒤 정해진 한도를 초과하면 더 작게 리팩터링할 것인지 결정해야 한다.

        2. 확장성: 작은 클래스에서 상속하기가 더 쉽다, 의도치 않은 기능 장애를 걱정할 필요 없이 클래스를 수정하거나 대체해야한다.
        
        3. 재사용성: 게임의 다른 부분에 재사용할 수 있도록 클래스를 작은 모듈형으로 디자인해야 한다.
    */
}
