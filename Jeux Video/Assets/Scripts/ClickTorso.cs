using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickTorso : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Image whatToClick;

    public enum Body { torso, arms, legs, head };

    Body currentPart;
    public void onClick()
    {
        currentPart = Body.torso;
        image.gameObject.SetActive(true);
        whatToClick.gameObject.SetActive(false);
        text.text = "Please select one of the muscle buttons on the bottom left";
        text.fontSize = 8;
    }

    public void onClickFreestyle()
    {
        if (image.gameObject.activeSelf && currentPart == Body.torso)
            text.text = "Full-Body Engagement in Freestyle \r\n\r\nSwimming freestyle involves a continuous, alternating movement of the arms and a flutter kick with the legs, supported by a strong and stable core. Roughly 90% of the propulsion comes from the upper body, especially the shoulders and back, with the remaining 10% from the legs. However, while the arms provide power, the legs and core are vital for balance, alignment, and effective movement. ";
    }

    public void onClickBackStroke()
    {
        if(image.gameObject.activeSelf && currentPart == Body.torso)
            text.text = "Backstroke is the only competitive swimming stroke performed on the swimmer’s back. It is also the second slowest stroke, after breaststroke. Because the face always remains above the water, swimmers can breathe freely and maintain a steady rhythm. However, one of the main challenges in backstroke is maintaining a straight line and consistent direction without visual reference to the pool bottom or lane markings. The stroke requires excellent shoulder flexibility, core stability, and rhythm. ";
    }


    public void onClickBreaststroke()
    {
        if(image.gameObject.activeSelf && currentPart == Body.torso)
            text.text = "Breaststroke is a unique stroke, it is the only stroke in which the arms recover over the water, instead of above it. It is also the slowest of the four competitive strokes. The kick in breaststroke is also different from the kick in the other strokes. Breaststroke is also the only stroke that has a glide phase, which has a period without movement. \r\n\r\nEach cycle in breaststroke consists of one arm pull and one leg kick. In breaststroke, the pull plays a smaller role than in the other strokes, it provides about 30% of the propulsion and 70% of the propulsion comes from the legs, making the kick important for speed and efficiency. ";
    }

    public void onClickButterfly()
    {
        if(image.gameObject.activeSelf && currentPart == Body.torso)
            text.text = "Butterfly \r\n\r\nWhen performed well, butterfly looks effortless and powerful. Its defining feature is that both arms recover above the water at the same time, creating the impression that the swimmer is flying. Despite what it looks like, butterfly is definitely not an easy stroke. It requires a lot of upper body power, precise timing and a lot of practice. \r\n\r\n  \r\n\r\nIn butterfly, the arm movement provides the most propulsion, while the legs and the core play a key role in maintaining a good balance.   ";
    }
}
