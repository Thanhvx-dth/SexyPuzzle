using UnityEngine;
using System.Collections;

public class ResultPanel : AnimatedPanel
{

    [Header("\tPanel Field")]

    [SerializeField]
    UILabel panelNameLabel;
    public GUISkin skin;
    // Use this for initialization
    void Start()
    {

    }

    #region Panel

    protected override void PanelWillShow()
    {

    }
    protected override void PanelDidShow()
    {

    }
    protected override void PanelWillHide()
    {

    }
    protected override void PanelDidHide()
    {

    }
    #endregion
    public void BackToStage()
    {
        GameGui.instance.PushPanel("StagePanel");
    }
    public void Retry()
    {
        GameGui.instance.PushPanel("GamePanel");
    }
    public void NextLevel()
    {
        CsManager.stageNum++;
        GameGui.instance.PushPanel("GamePanel");
    }
    void OnGUI()
    {
        GUI.skin = skin;

        int w = Screen.width;
        int h = Screen.height;

        string picturea = "Pictures/" + CsManager.picture + "/" + CsManager.picture + CsManager.stageNum;
        Texture2D img = Resources.Load(picturea) as Texture2D;
        GUI.DrawTexture(new Rect(50, 100, w-100, h-178), img);
    }
}
