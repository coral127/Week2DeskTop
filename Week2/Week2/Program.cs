using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Reflection.Metadata;

public class Calculator
{
    public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

public void Multiple(int num1, int num2)
{
    int result = num1 * num2;
    Console.WriteLine($"{num1} x {num2} = {result}");
}
}

public void Sum(params int[] values)
{
    int sum = 0;
    for(int i = 0; i < values.Length; ++i)
    {
        sum += values[i];
    }
    Console.WriteLine($"합계:{sum}");
}

public class 클래스이름
{
 //변수(데이터)와 메소드
}

public class Player : //부모 클래스
    {
     
    }

//public : 외부에서 클래스를 통해 접근할 수 있음
//private : 외부에서 접근할 수 없으며, 하위 클래스에서도 접근할 수 없다.
//protected : 외부에서 접근할 수 없으며, 하위 클래스에서는 접근할 수 있다.
//private는 디폴트 지정자로, 접근 지정자를 표기하지 않으면 private로 자동 설정됨.

public class Player
{
    private int curentHP;

    public void SetCurrentHP(int hp)
    {
        if (hp > 0)
        {
            currentHP = hp;
        }
    }

    public int GetCurrentHP()
    {
        return GetCurrentHP;
    }
}

public class Entity     //부모클래스
{
    public string ID;
    protected int currentHP;

    private void Initialize()
    {
        ID = "Noname";
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
}

public class Player : Entity    ///상속받기
{
    public Player(string id, int hp)
    {
        ID = id;
        ccurrentHP = hp;

        RecoveryHP(1000);

        //private이기 때문에 사용불가
        Initalize();
    }
}

public class Player : Entity
{
    private string ID;

    public Player(string id, int hp)
    {
        base.ID = "Noname";    //base로 부모클래스 참조
        ID = id;
        currnetHP = hp; 
    }
}

public class Entity
{
    public virtual void Attack()   //virtual붙임
    {
        Debug.Log("적을 공격한다.");
    }
}

public class Slime : Entity
{
    public override void Attack() //override붙임, 업 캐스팅을 해도 부모클래스의 값이 아닌 자식클래스의 값을 사용할 수 있음
    {
        Debug.Log("슬라임의 몸통 박치기 공격!");
    }
}
public class Goblin : Entity
{
    public override void Attack() {

}

    public class Entity
    {
        public void Attack()
        {
            Debug.Log("적을 공격한다.");
        }
    }

    public class Slime : Entity
    {
    }

    public class Goblin : Entity
    {
    }

    //추상 메소드, 정의만 되고 내용은 없는 미완성 클래스. new 사용불가
    //추상 메소드는 추상 클래스에서만 정의
    //추상 메소드를 정의할 때 static, virtual 사용불가, abstract사용함

    public abstract class Entity        //추상클래스 예
    {
        protected int damage;
        protected int currentHP;

        public abstract void Attack(Entity target);
        public void TakeDamage(int damage)
        {
            if(currentHP > damage) {
                currentHP -= damage;
                Debug.Log($"체력이 {damage}감소");
        }
            else
            {
                Debug.Log("Die");  
            }
    }

    //인터페이스
    //인터페이스는 메소드, 프로퍼티, 인덱서, 이벤트만 선언가능
    //인터페이스는 구현부가 없음
    //인터페이스는 접근 지정자 사용불가능, 모든 것이 public
    //인터페이스는 new연산자를 이용해 인스턴스를 생성할 수 없다.
    // 표준화, 개발시간 단축, 독립적 프로그래밍을 가능케 해준다.

    interface IMovingEntity
        {
            
        }

  //메소드 숨기기
    public class Parent
        {
            public void Method01()
            {
                Debug.Log("Parent");
            }
        }

    public class Child : Parent
        {
            public new void Method01()
            {
                Debug.Log("Child");
            }
        }

    pulic class GameController : MonoBehavior
        {
            private void Awake()
            {
                Parent p = new Parent();
                p.Method01();

                Child c = new Child(); 
                c.Method01();

                Parent pc = new Child();
                pc.Method01();   
            }

//중첩 클래스. 클래스 안에 선언되어 있는 클래스
// 클래스들의 논리적인 그룹을 나타내기 위해 사용
// 클래스 외부에 공개하고 싶지 않은 형식을 만들어서 클래스 내부에서만 사용할 때(향상된 캡슐화)
//좋은 가독성과 유지보수

//분할 클래스. 하나의 클래스를 여러 구역으로 나눠서 구현하는 클래스
//규모가 크더라도 하나의 클래스에 담아야 할 경우
//어떤 특징으로 여러 개의 파일에 나누어 구현할 때 사용

 