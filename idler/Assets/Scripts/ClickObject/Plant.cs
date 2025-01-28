public class Plant : ClickableObjects
{
    protected override void GetDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            transform.parent.GetComponent<ObjectFromResources>().plantDead = true;
            Destroy(gameObject);
        }
    }
    protected override void Move()
    {
        
    }
}
