public class Riffle : Gun
{
    public override void Shot()
    {
        base.Shot();
        AddBullet();
    }
}