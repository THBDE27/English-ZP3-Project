using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static ClickTorso;

public class ClickLegs : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Image whatToClick;
    ClickTorso.Body bodyPart;
    public void onClick()
    {
        bodyPart = ClickTorso.Body.legs;
        print(bodyPart);
        image.gameObject.SetActive(true);
        whatToClick.gameObject.SetActive(false);
        text.text = "Please select one of the muscle buttons on the bottom left";
        text.fontSize = 8;
    }

    public void onClickFreestyle()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.legs)
            text.text = "The legs \r\n\r\nThe kick in freestyle is known as the flutter kick, an alternating motion with straight or slightly bent legs. Though not the main source of propulsion, a well-timed and consistent kick improves balance, reduces drag and maintains horizontal body position. The kick can be split in two movements: the downbeat and the upbeat. \r\n\r\n    Downbeat (kick downward): \r\n\r\nThe quadriceps are used to extend the knee, and the hip flexors bring the thigh forward and down. \r\n\r\n    Upbeat (kick upward): \r\n\r\nThe hamstrings flex the knee and the gluteus maximus (glutes) helps lift the leg to the surface. The gastrocnemius and the soleus (calf muscles) are also used to maintain the ankles extended and the toes pointed. ";
    }

    public void onClickBackStroke()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.legs)
            text.text = "The legs \r\nThe kick in backstroke is the same as in freestyle, which is flutter kick, an up and down alternating motion with straight or slightly bent legs. Kick provides propulsion, helps with the rotation of the body and improves body position. Since most people have their hips and feet sinking in the water when they are swimming on their back, kick is important to keep these at the surface which reduces drag. Though not the main source of propulsion, a well-timed and consistent kick improves balance, reduces drag and maintains horizontal body position. The kick can be split in two movements: the downbeat and the upbeat.  \r\n   Downbeat (kick downward): \r\nWhen the leg goes downward through the water, the hamstrings and the gluteal muscles (glutes) power the movement. In backstroke, these muscles work harder than they do in freestyle since the swimmer is on their back which require greater effort to stay at the surface and stay aligned.\r\n  Upbeat (kick upward): \r\nThe hip flexors and quadriceps move the leg toward the surface. The hamstrings flex the knee slightly and the gluteus maximus (glutes) helps lift the leg to the surface. The gastrocnemius and the soleus (calf muscles) are also used to maintain the ankles extended and the toes pointed but it is also important that the muscles in your shins (tibialis anterior) to be flexible and supple which will allow your feet to push effectively against the water.  ";
    }


    public void onClickBreaststroke()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.legs)
            text.text = "Kick \r\n\r\nKick in breaststroke is also completely different from kick in other strokes. In breaststroke, the feet are turned out instead of in and the legs move forward and backward in a simultaneous circular motion instead of up and down. \r\n\r\nThere are two main phases: the outsweep and the propulsive phase. \r\n\r\n    Outsweep \r\n\r\nThis is the phase where the legs are being brought towards the hips. The hamstrings bend the knees and bring the heels to the hips with the help of the hip flexors. The tibialis anterior are used to turn the feet outward. \r\n\r\n  \r\n\r\n    Propulsive phase \r\n\r\nThis is the phase where the swimmer kick backward. The quadriceps and glutes push backward against the water and extend the legs. At the end of the kick, the abductors squeeze the legs together to create the most propulsion. ";
    }

    public void onClickButterfly()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.legs)
            text.text = "The legs  \r\n\r\nThe kick in butterfly is a simultaneous double legged kick, which means that both legs move together. The kick, just like in freestyle and backstroke, is vertical, with an up and down motion. It is important for the kick to be timed well, since the kick is essential to keep the hips from sinking when the swimmer breath. A great kick also helps to reduce drag during breathing. The kick can be split in two movements: the downbeat and the upbeat.  \r\n\r\n    Downbeat (kick downward):  \r\n\r\nThe quadriceps are used to extend the knee, and the hip flexors bring the thigh forward and down.  \r\n\r\n    Upbeat (kick upward):  \r\n\r\nThe muscles in the back of the legs (hamstrings and glutes) are used to lift the legs to the surface. The abdominal muscles and erector spinae muscles are also used in the up kick to control the hips position. Just like in freestyle, it is important to keep the ankles extended and the toes pointed by using the gastrocnemius and the soleus (calf muscles. ";
    }
}
