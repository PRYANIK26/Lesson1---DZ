public class Pistol : Gun
{
    public override void Shot()
    {
        base.Shot();

        if (Patrons <= 0) return;

        Patrons -= GunConfig.PatronsPerShot;
        AddBullet();
    }
}
