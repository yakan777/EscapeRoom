using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Maze : MonoBehaviour
{
    public CameraControll cc;
    public GameObject[] wallPrefab;
    //public GameObject player;

    public Transform wallParent;
    const int MAPSIZE = 51;
    int[] direction = new int[] { 0, 1, 2, 3 };
    List<int> stackX = new List<int>();
    List<int> stackY = new List<int>();
    bool[,] isWall = new bool[MAPSIZE, MAPSIZE];
    public GameObject player;
    GameObject[,] wallData = new GameObject[MAPSIZE, MAPSIZE];
    // Start is called before the first frame update
    public bool[,] GetMap()
    {
        return isWall;
    }
    void Start()
    {

        for (int i = 0; i < MAPSIZE; i++)
        {
            for (int j = 0; j < MAPSIZE; j++)
            {
                isWall[i, j] = true;
            }
        }
        MakeMaze();
        for (int i = 0; i < MAPSIZE; i++)
        {
            for (int j = 0; j < MAPSIZE; j++)
            {
                int rand=0;//UnityEngine.Random.Range(0,16);
                if (isWall[i, j])
                {
                    GameObject allWall = (GameObject)Instantiate(
                    wallPrefab[rand],
                    new Vector3(j*2f, 0, i*2f),
                    Quaternion.identity
                );
                    wallData[i, j] = allWall;
                    allWall.transform.parent = wallParent;
                }
            }
        }



    }

    void MakeMaze()
    {
        int x = 2 * (UnityEngine.Random.Range(1, MAPSIZE / 2 - 1)) + 1;
        int y = 2 * (UnityEngine.Random.Range(1, MAPSIZE / 2 - 1)) + 1;
        isWall[y, x] = false;
        GameObject unitychan=Instantiate(
            player,
            new Vector3(x,0.1f,y),
            Quaternion.identity
        );
        cc.player=unitychan;
        Debug.Log(x + " " + y + "start");
        stackX.Add(x);
        stackY.Add(y);
        Dig(x, y);

    }

    bool IsDig(int index, int x, int y)
    {
        if (index == 0 && x + 2 <= MAPSIZE - 1 && isWall[y, x + 2] && ((isWall[y, x + 1] && isWall[y - 1, x + 1]) && (isWall[y + 1, x + 1])))
        {
            return true;
        }
        if (index == 1 && x - 2 >= 0 && isWall[y, x - 2] && ((isWall[y, x - 1] && isWall[y - 1, x - 1]) && (isWall[y + 1, x - 1])))
        {
            return true;
        }
        if (index == 2 && y + 2 <= MAPSIZE - 1 && isWall[y + 2, x] && ((isWall[y + 1, x] && isWall[y + 1, x + 1]) && (isWall[y + 1, x - 1])))
        {
            return true;
        }
        if (index == 3 && y - 2 >= 0 && isWall[y - 2, x] && ((isWall[y - 1, x] && isWall[y - 1, x + 1]) && (isWall[y - 1, x - 1])))
        {
            return true;
        }
        return false;
    }

    bool IsDig(int x, int y)
    {
        if (x + 2 <= MAPSIZE - 1 && isWall[y, x + 2] && ((isWall[y, x + 1] && isWall[y - 1, x + 1]) && (isWall[y + 1, x + 1])))
        {
            return true;
        }
        if (x - 2 >= 0 && isWall[y, x - 2] && ((isWall[y, x - 1] && isWall[y - 1, x - 1]) && (isWall[y + 1, x - 1])))
        {
            return true;
        }
        if (y + 2 <= MAPSIZE - 1 && isWall[y + 2, x] && ((isWall[y + 1, x] && isWall[y + 1, x + 1]) && (isWall[y + 1, x - 1])))
        {
            return true;
        }
        if (y - 2 >= 0 && isWall[y - 2, x] && ((isWall[y - 1, x] && isWall[y - 1, x + 1]) && (isWall[y - 1, x - 1])))
        {
            return true;
        }
        return false;
    }

    int Index(int x, int y)
    {
        /*List<int> direction = new List<int>() { 0, 1, 2, 3 };
        while (true)
        {
            int index = Random.Range(0, direction.Count);
            Debug.Log(index);
            Debug.Log(direction[index] + "方向");
            if (IsDig(direction[index], x, y))
            {
                Debug.Log(direction[index] + "return");
                return direction[index];
            }
            else
            {
                Debug.Log(direction[index] + "delete");
                direction.RemoveAt(index);
                if (direction.Count == 0)
                {
                    return 4;
                }
            }
        }*/
        int[] shuffle = direction.OrderBy(i => Guid.NewGuid()).ToArray();
        for (int i = 0; i < shuffle.Length; i++)
        {
            if (IsDig(shuffle[i], x, y))
            {
                return shuffle[i];
            }
        }
        return 4;


    }

    void Dig(int x, int y)
    {
        while (true)
        {
            int direction = Index(x, y);
            if (direction == 0)
            {
                x++;
                isWall[y, x] = false;
                x++;
                isWall[y, x] = false;
                stackX.Add(x);
                stackY.Add(y);
                Debug.Log(x + " " + y + "追加");
            }
            if (direction == 1)
            {
                x--;
                isWall[y, x] = false;
                x--;
                isWall[y, x] = false;
                stackX.Add(x);
                stackY.Add(y);
                Debug.Log(x + " " + y + "追加");
            }
            if (direction == 2)
            {
                y++;
                isWall[y, x] = false;
                y++;
                isWall[y, x] = false;
                stackX.Add(x);
                stackY.Add(y);
                Debug.Log(x + " " + y + "追加");
            }
            if (direction == 3)
            {
                y--;
                isWall[y, x] = false;
                y--;
                isWall[y, x] = false;
                stackX.Add(x);
                stackY.Add(y);
                Debug.Log(x + " " + y + "追加");

                Debug.Log(x + " " + y);
            }





            if (direction == 4)
            {
                int ida = IsDigAble(x, y);
                Debug.Log(stackX.Count);
                Debug.Log(IsDigAble(x, y));
                if (ida != -1)
                {
                    x = stackX[ida];
                    y = stackY[ida];
                }
                Debug.Log(x + "T3");
                if (ida == -1)
                {
                    Debug.Log("yobimasita");
                    break;
                }
            }
        }

    }
    int IsDigAble(int x, int y)
    {
        for (int i = 0; i < stackX.Count; i++)
        {
            x = stackX[i];
            y = stackY[i];
            if (IsDig(stackX[i], stackY[i]))
            {
                Debug.Log("true");
                Debug.Log(x + "T1");
                x = stackX[i];
                y = stackY[i];
                Debug.Log(x + "T2");
                return i;
            }
        }
        return -1;
    }
    void Update()
    {

    }
}
