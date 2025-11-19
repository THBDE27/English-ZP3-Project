using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static ClickTorso;

public class ClickHead : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Image whatToClick;

    ClickTorso.Body bodyPart;
    public void onClick()
    {
        bodyPart = ClickTorso.Body.head;
        image.gameObject.SetActive(true);
        whatToClick.gameObject.SetActive(false);
        text.text = "Please select one of the muscle buttons on the bottom left";
        text.fontSize = 8;
    }

    public void onClickFreestyle()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.head)
            text.text = "Body position \r\n\r\nTo maintain an effective position in the water, and an effective rotation, you also need to use your abdominal muscles and your obliques. The core should be engaged during the whole stroke, but it is especially important to keep it engaged during the pull and the kick phases. You also need your lower back muscles and your hip flexors and glutes to create tension in your back which maintain your spine straight and keeps your legs close to the surface which keeps them from sinking and creating drag. \r\n\r\nA strong core also ensures that the rotation of the body comes primarily from the shoulders, not from bending the spine. ";
    }

    public void onClickBackStroke()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.head)
            text.text = "Body position \r\n\r\nThe abdominal muscles are key, they help the overall body position and the rotation. You need your abdominal muscles, and your obliques to keep the body at the surface. Your core is going to be engaged through the whole movement the stay afloat. You also need to keep the spine straight and rotate it lengthwise. To do this, you need to use your internal and external obliques, your erector spinal, your rectus abdominal and other small spinal muscles. These muscles help stabilize the spine during rotation.  ";
    }


    public void onClickBreaststroke()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.head)
            text.text = "Kick \r\n\r\nKick in breaststroke is also completely different from kick in other strokes. In breaststroke, the feet are turned out instead of in and the legs move forward and backward in a simultaneous circular motion instead of up and down. \r\n\r\nThere are two main phases: the outsweep and the propulsive phase. \r\n\r\n    Outsweep \r\n\r\nThis is the phase where the legs are being brought towards the hips. The hamstrings bend the knees and bring the heels to the hips with the help of the hip flexors. The tibialis anterior are used to turn the feet outward. \r\n\r\n  \r\n\r\n    Propulsive phase \r\n\r\nThis is the phase where the swimmer kick backward. The quadriceps and glutes push backward against the water and extend the legs. At the end of the kick, the abductors squeeze the legs together to create the most propulsion. ";
    }

    public void onClickButterfly()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.head)
            text.text = "The legs  \r\n\r\nThe kick in butterfly is a simultaneous double legged kick, which means that both legs move together. The kick, just like in freestyle and backstroke, is vertical, with an up and down motion. It is important for the kick to be timed well, since the kick is essential to keep the hips from sinking when the swimmer breath. A great kick also helps to reduce drag during breathing. The kick can be split in two movements: the downbeat and the upbeat.  \r\n\r\n    Downbeat (kick downward):  \r\n\r\nThe quadriceps are used to extend the knee, and the hip flexors bring the thigh forward and down.  \r\n\r\n    Upbeat (kick upward):  \r\n\r\nThe muscles in the back of the legs (hamstrings and glutes) are used to lift the legs to the surface. The abdominal muscles and erector spinae muscles are also used in the up kick to control the hips position. Just like in freestyle, it is important to keep the ankles extended and the toes pointed by using the gastrocnemius and the soleus (calf muscles. ";
    }
}
