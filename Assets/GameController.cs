using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    Contexts contexts;
    GameSystems gameSystems;
    public Text text;

	// Use this for initialization
	void Start () {
        contexts = Contexts.sharedInstance;
        gameSystems = new GameSystems(contexts);
        gameSystems.Initialize();
    }
	
	// Update is called once per frame
	void Update () {

        gameSystems.Execute();
		
	}
    public void ButtonPressed()
    {
        contexts.input.CreateEntity().isButton = true;        
    }   
}
