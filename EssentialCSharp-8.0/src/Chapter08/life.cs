using System;
class Program
{
    public class Main
    {
        /*
        MainCharacter myMainCharacter = new MainCharacter();
        Zombie zombie = new Zombie();
        Ghost ghost = new Ghost();

    myMainCharacter.Init();
    zombie.Init();
    ghost.Init();

    myMainCharacter.Attack(zombie);
    System.Console.WriteLine();
    zombie.attack(myMainCharacter);
    System.Console.WriteLine();
    ghost.attack(myMainCharacter);
    System.Console.WriteLine();
    zombie.Attack(zombie);
    System.Console.WriteLine();
    System.Console.ReadKey();
        */
    }
}
/*
interface ILifeEntity // hit, attack
{
    void Attack(LifeEntity lifeEntity);
    void Hit(int attackDamage);
}
class LifeEntity : ILifeEntity // hit, attack 상속받음 + 체력, 공격력 
{
    protected int attackDamage = 0;
    protected int _Hp = 100;

    public int Hp
    {
        get
        {
            return _Hp;
        }
        protected set
        {
            _Hp = value;
        }
    }
        
    public string name = "";
    

    public virtual void Init()
    {

    }

    public  void Attack(LifeEntity lifeEntity)
    {
        System.Console.WriteLine(name + ":" + lifeEntity.name + " 나는 공격 받았다.");
        System.Console.WriteLine(name + ":" + lifeEntity.name + "의 체력은 "+lifeEntity.Hp+"이다!");
    }
    public virtual void  Hit(int attackDamage)
    {
        Hp -= attackDamage;
        System.Console.WriteLine(name + ":" + " 나는 공격 받았다.");
        System.Console.WriteLine(name + ":" + Hp + "만큼 체력이 남았다.");
    }

    public virtual void Attack(LifeEntity lifeEntity)
    {
        throw new NotImplementedException();
    }

    public virtual void Hit(int attackDamage)
    {
        throw new NotImplementedException();
    }
}

class MainCharacter: LifeEntity
{
    public override void Init()
    {
        attackDamage = 10;
        Hp = 100;
        name = "메인 캐릭터";
    }
    public override void Attack(LifeEntity lifeEntity)
    {
        base.Attack(lifeEntity);
    }
    public override void Hit(int attackDamage)
    {
        base.Hit(attackDamage);
    }
}

class Monster: LifeEntity
{
    public override void Init()
    {
        attackDamage = 3;
        Hp = 50;
        name = "몬스터";
    }
    public override void Attack(LifeEntity lifeEntity)
    {
        base.Attack(lifeEntity);
    }
    public override void Hit(int attackDamage)
    {
        base.Hit(attackDamage);
    }
}

class Zombie: Monster
{
    public override void Init()
    {
        base.Init();
        name = "좀비";
    }
}

class Ghost : Monster
{
    public override void Init()
    {
        base.Init();
        name = "유령";
    }
}*/