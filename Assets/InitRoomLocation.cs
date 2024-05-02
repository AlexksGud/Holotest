using UnityEngine;

public class InitRoomLocation : MonoBehaviour
{
    [SerializeField] private Transform _platrform;

    [SerializeField] private Transform _mainRoom;

    [SerializeField] private Transform _accepPosButt;


    public void SetPosition()
    {

        _platrform.gameObject.SetActive(false);
        _accepPosButt.gameObject.SetActive(false);

        _mainRoom.position = new(_platrform.position.x, _platrform.position.y, _platrform.position.z);
        _mainRoom.gameObject.SetActive(true);

    }

    public void AppearPosButt(bool value)
    {
        if (value)
        {
            _accepPosButt.gameObject.SetActive(true);
            _accepPosButt.transform.position = _platrform.position + Vector3.up * 0.2f;
        }
        else
        {
            _accepPosButt.gameObject.SetActive(false);
        }
    }
}
