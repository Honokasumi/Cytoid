using UnityEngine;
using UnityEngine.UI;

public class GameObjectProvider : SingletonMonoBehavior<GameObjectProvider>
{
     public GameObject clickNotePrefab;
     public GameObject dragChildNotePrefab;
     public GameObject cDragHeadNotePrefab;
     public GameObject dragHeadNotePrefab;
     public GameObject dragLinePrefab;
     public GameObject flickNotePrefab;
     public GameObject holdNotePrefab;
     public GameObject longHoldNotePrefab;
     public NoteId noteIdPrefab;
     public Image cover;
     public GameObject boundaryBottom;
     public GameObject boundaryTop;
     public BeatPulseVisualizer beatPulseVisualizer;
     public GameMessageText messageText;
     public CircleProgressIndicator circleProgressIndicator;
}