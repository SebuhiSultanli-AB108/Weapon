namespace WeaponProject.Models;

class Weapon
{
    private int _maxAmmo;
    private int _ammo;
    private int _magFixedMtSec;
    private bool _isAuto;

    public Weapon(int maxAmmo, int ammo, int magFixedMtSec, bool isAuto)
    {
        MaxAmmo = maxAmmo;
        Ammo = ammo;
        MagFixedMtSec = magFixedMtSec;
        _isAuto = isAuto;
    }

    public int MaxAmmo
    {
        get { return _maxAmmo; }
        set { _maxAmmo = value; }
    }

    public int Ammo
    {
        get { return _ammo; }
        set
        {
            if (value > _maxAmmo)
            {
                Console.WriteLine("What a waste of ammo !!!");
                _ammo = _maxAmmo;
            }
            else if (value < 0)
            {
                Console.WriteLine("Cant be less than 0!");
                _ammo = 0;
            }
            else
                _ammo = value;
        }
    }

    public int MagFixedMtSec
    {
        get { return _magFixedMtSec; }
        set { _magFixedMtSec = value; }
    }

    public bool IsAuto
    {
        get { return _isAuto; }
        set { _isAuto = value; }
    }

    public void Shoot()
    {
        if (Ammo == 0)
            AutoReload();
        else
        {
            Ammo--;
            Console.WriteLine("Fired one bullet!");
        }
    }
    public void Fire()
    {
        if (Ammo == 0)
            AutoReload();
        if (!IsAuto) Shoot();
        else
        {
            float magMtSec;
            magMtSec = Convert.ToSingle(Ammo * MagFixedMtSec) / MaxAmmo;
            Ammo = 0;
            Console.WriteLine($"Fired all of the remining bullets in {magMtSec}");
        }
    }
    public int GetRemainBulletCount()
    {
        return MaxAmmo - Ammo;
    }

    public void MagInfo()
    {
        Console.WriteLine("Current bullets: " + Ammo);
    }

    public void Reload()
    {
        if (Ammo < MaxAmmo) Ammo = MaxAmmo;
        {
            Console.WriteLine("Reload!");
        }
    }
    public void AutoReload()
    {
        Console.WriteLine("No ammo to shoot!");
        Console.WriteLine("Auto reloading!");
        Reload();
    }
    public void AddAmmo(int ammo)
    {
        Ammo += ammo;
    }
    public void ChangeFireMode(bool isAuto)
    {
        IsAuto = isAuto;
        if (isAuto) Console.WriteLine("Fire mode: Auto");
        else Console.WriteLine("Fire mode: Single");
    }
}

