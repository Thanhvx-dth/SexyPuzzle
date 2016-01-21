using UnityEngine;
using System.Collections;

public class TitlePanel : AnimatedPanel {


	[Header("\tPanel Field")]

	[SerializeField] UILabel panelNameLabel;

	#region Panel
	
	protected override void PanelWillShow ()
	{
       
        int adid = 0;
        if (!UM_AdManager.IsInited)
        {
            UM_AdManager.Init();
        }
        if (adid <= 0)
        {
            adid = UM_AdManager.CreateAdBanner(TextAnchor.LowerCenter);
            UM_AdManager.ShowBanner(adid);
        }
    }
	protected override void PanelDidShow ()
	{
		
	}
	protected override void PanelWillHide ()
	{
		
	}
	protected override void PanelDidHide ()
	{
		
	}
	#endregion

	#region function for Button
	public void StartGame(){
		GameGui.instance.PushPanel("StagesPanel");
	}
	public void Setting(){
		Debug.LogError ("Setting");
	}
	public void Quit(){
		AlertPanel.Show ("xxxxxxx",
		                 (ok) => {
			if(ok){
				Application.Quit();
			}

		}, true);
	}

	#endregion

	#region function 

	#endregion
}
