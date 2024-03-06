using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GunSelector : MonoBehaviour
{
    [SerializeField] private GunsConfig _gunsConfig;
    [SerializeField] private List<Gun> _gunsList;
    [SerializeField] private Gun _currentGun;

    private Queue<Gun> _gunsQueue;
    private Player _player;
    

    private void Awake()
    {
        _player = GetComponent<Player>();
        
        //И тут я тоже запутался(((
        foreach (var gun in _gunsList)
        {
            GunConfig config = gun switch
            {
                Pistol => _gunsConfig.PistolConfig,
                Riffle => _gunsConfig.RifleConfig,
                Shotgun => _gunsConfig.ShotgunConfig,
                _ => throw new ArgumentOutOfRangeException()
            };
            gun.Initialize(config);
        }
        
        _gunsQueue = new Queue<Gun>(_gunsList.Select(gun => gun));
        _currentGun = _gunsQueue.Dequeue();
        
        SetGun();
    }

    private void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0)
        {
            _gunsQueue.Enqueue(_currentGun);
            _currentGun = _gunsQueue.Dequeue();
            SetGun();
        }
        else if (scroll < 0)
        {
            //как можно адекватно сделать чтобы очередь крутилась в обе стороны, без такого как я сделал?)
            _gunsQueue.Enqueue(_currentGun);
            _currentGun = _gunsQueue.Dequeue();
            _gunsQueue.Enqueue(_currentGun);
            _currentGun = _gunsQueue.Dequeue();
            SetGun();
        }
    }

    void SetGun()
    {
        _player.SetGun(_currentGun);
    }
}
