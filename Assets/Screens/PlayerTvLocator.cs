using UnityEngine;

public class PlayerTvLocator :MonoBehaviour
{
    public Transform scene;

    public TV[] screens;
    public bool deleteTool = false;

    private TV _selected;
    private void Awake()
    {
        _selected = screens[0];
    }
    public void SetScreen(int indx) 
    {
        switch (indx)
        {
            case 22:
                _selected = screens[0];
                deleteTool = false;
                return;

            case 27:
                _selected = screens[1];
                deleteTool = false;
                return;

            case 55:
                _selected = screens[2];
                deleteTool = false;
                return;

            case 0:
                _selected = screens[0];
                deleteTool = true;

                return;
        }
    }

    public void WallClick(Wall wall) 
    {
        if (deleteTool)
            return;

        var newTv = Instantiate(_selected);

        newTv.transform.position = wall.transform.position;
        newTv.SetWall(wall.transform.rotation.eulerAngles.y, wall.xorZWallFixedCoor,this);
    }

    public void MoveDown() 
    {
        var p = scene.transform.position;
        scene.transform.position = new Vector3(p.x, p.y - 0.1f,p.z);
    }

    public void MoveUp()
    {
        var p = scene.transform.position;
        scene.transform.position = new Vector3(p.x, p.y + 0.1f, p.z);
    }
}

