using UnityEngine;
using System.Collections;

public class LevelInfo {

  private  int levelId;

    public int LevelId
    {
        get { return levelId; }
        set { levelId = value; }
    }
  protected  string levelName;

    public string LevelName
    {
        get { return levelName; }
        set { levelName = value; }
    }
    protected string levelPassWord;

    public string LevelPassWord
    {
        get { return levelPassWord; }
        set { levelPassWord = value; }
    }

    public LevelInfo(int levelid,string levelname,string levelPsw)
    {
        this.LevelId = levelid;
        this.LevelName = levelname;
        this.LevelPassWord = levelPsw;
    }
}
