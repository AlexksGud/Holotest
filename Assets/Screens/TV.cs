using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Data;
using UnityEngine;

public class TV : MonoBehaviour
{
    [SerializeField] private Collider boxCol;
    [SerializeField] private MoveAxisConstraint moveAxisConstraint;
    [SerializeField] private Interactable interactable;

    private bool located;
    private PlayerTvLocator player;

    public bool Located
    {
        get { return located; }
        set
        {
            located = value;

            if (value)
                boxCol.enabled = true;
            else
                boxCol.enabled = false;
        }
    }

    public void SetWall(float rot,XorZWallFixedCoor XorZ, PlayerTvLocator player) 
    {
        this.player = player;
        interactable.OnClick.AddListener(Delete);


        transform.rotation = Quaternion.Euler(0f, rot, 0f);

        if (XorZ == XorZWallFixedCoor.Z) 
        {
            moveAxisConstraint.ConstraintOnMovement = AxisFlags.ZAxis;
        }
        else 
        {
            moveAxisConstraint.ConstraintOnMovement = AxisFlags.XAxis;
        }
    }
    
    public void Delete() 
    {
        if (player.deleteTool) 
        {
            Destroy(this.gameObject);
            interactable.OnClick.RemoveListener(Delete);
        }
        
    }
}

