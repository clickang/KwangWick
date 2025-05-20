using UnityEngine;
using System;

public class Target : MonoBehaviour
{
    public event Action OnTargetDestroyed;

    private bool isPeeking;

    public void Initialize(bool isPeeking)
    {
        this.isPeeking = isPeeking;

        // 타겟 타입에 따른 초기화 로직
        if (isPeeking)
        {
            SetupPeekingBehavior();
        }
        else
        {
            SetupMovingBehavior();
        }
    }

    private void SetupPeekingBehavior()
    {
        // 피킹 타겟 전용 동작 설정
        // 예: 피킹 애니메이션, 콜라이더 등
    }

    private void SetupMovingBehavior()
    {
        // 움직이는 타겟 전용 동작 설정
        // 예: 이동 경로, 속도 등
    }

    // 타겟이 파괴될 때 (히트 또는 시간 초과)
    public void DestroyTarget()
    {
        OnTargetDestroyed?.Invoke();
        Destroy(gameObject);
    }

    // 타겟이 맞았을 때 호출되는 메서드
    public void Hit()
    {
        // 히트 효과, 점수 등의 로직
        DestroyTarget();
    }

    // Test
    private void Test()
    {
        float randomDelay = UnityEngine.Random.Range(1f, 3f);
        Invoke("DestroyTarget", randomDelay);
    }
    private void Start()
    {
        Test();
    }
    //
}