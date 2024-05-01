using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

public class InitRoomLocation : MonoBehaviour
{
    [SerializeField] private Transform _platrform;
    [SerializeField] private Transform _prototyperoom;

    [SerializeField] private Transform _mainRoom;

    [SerializeField] private Transform _accepPosButt, _acceptRotButt;


    public void SetPosition()
    {
        _prototyperoom.position = new(_platrform.position.x, _platrform.position.y, _platrform.position.z);
        _acceptRotButt.transform.position = _prototyperoom.position + Vector3.up * 0.3f;

        _platrform.gameObject.SetActive(false);
        _prototyperoom.gameObject.SetActive(true);


    }
    public void SetMainRoom()
    {

        _mainRoom.position = new(_platrform.position.x, _platrform.position.y, _platrform.position.z);
        _mainRoom.rotation = _prototyperoom.rotation;
        _mainRoom.gameObject.SetActive(true);
        _prototyperoom.gameObject.SetActive(false);

        _acceptRotButt.gameObject.SetActive(false);
        _accepPosButt.gameObject.SetActive(false);
    }

    public void AppearPosButt(bool value) 
    {
        if (value)         
        {
            _accepPosButt.gameObject.SetActive(true);
            _accepPosButt.transform.position = _platrform.position + Vector3.up*0.1f;
        }
        else 
        {
            _accepPosButt.gameObject.SetActive(false);
        }
    }
    public void AppearRotButt(bool value)
    {
        if (value)
        {
            _acceptRotButt.gameObject.SetActive(true);
            _acceptRotButt.transform.position = _prototyperoom.position + Vector3.up * 0.3f;
        }
        else
        {
            _acceptRotButt.gameObject.SetActive(false);
        }
    }
}
