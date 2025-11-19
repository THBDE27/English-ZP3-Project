using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using static ClickTorso;

public class ClickArm : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Image whatToClick;

    ClickTorso.Body bodyPart;
    public void onClick()
    {
        bodyPart = ClickTorso.Body.arms;
        image.gameObject.SetActive(true);
        whatToClick.gameObject.SetActive(false);
        text.text = "Please select one of the muscle buttons on the bottom left";
        text.fontSize = 8;
    }

    public void onClickFreestyle()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.arms)
            text.text = "The arm stroke in freestyle can be split into four phases: \r\n Hand Entry, Catch, Pull, Recovery \r\n Each phase involves a different set of muscles: \r\n  Hand entry \r\nThe multiples muscles in the wrist help stabilize the hands and keep them in the best position. \r\n Catch \r\n As the hand enters the water and prepares to pull, swimmers activate their pectorals (chest muscles) and the latissimus dorsi and trapezius which are large upper and middle back muscles. \r\n Pull \r\n This is where most of the forward motion is generated. Swimmers use their shoulder adductors, extensors and internal rotators to provide the stroke power and their latissimus dorsi and serratus anterior for propulsion. They also use their biceps and triceps for elbow flexion and extension. They use their shoulder muscles (rotator cuff and deltoids), their middle back muscles (trapezius) and their rib cage muscle (serratus anterior) to stabilize and rotate the shoulder. \r\n Recovery  \r\n When the arm exits the water and swings forward, deltoids, trapezius, and rotator cuff muscles play a key role in maintaining shoulder stability and a fluid motion. ";
    }

    public void onClickBackStroke()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.arms)
            text.text = "Each phase activates a different set of muscles, many of which are the same as those used in freestyle, though there are some key differences due to body orientation and movement direction. \r\n    Hand entry \r\nDuring the hand entry phase, the swimmer’s hand enters the water little finger first, fully extended. The multiples wrist flexor muscles help stabilize the hands and forearms and keep them in the best position. \r\n   Catch \r\nWhen the hand enters the water and prepares to pull, you need to activate your lower and middle back muscles (latissimus dorsi and trapezius), your chest muscles (pectorals) and your arm muscles (biceps and triceps) to bend your elbow to prepare for the pull. \r\n   Pull \r\nDuring the pull, the latissimus dorsi are the muscles that provide a lot of the pulling power, the deltoids are also important in order to lift and rotate the arms. The arm muscles (biceps and triceps) are also used to provide power to the pull. You also need the trapezius and rhomboids to stabilize the shoulder blades throughout the movement. This stability is essential to maintain efficiency and reduce the risk of shoulder strain. \r\n    Recovery  \r\nIn backstroke, recovery is usually done with straight arms. The deltoids are used to raise the arms high above the water, the triceps extend the elbow as the arm gets out of the water, and the rotator cuff muscles control the shoulder rotation and stabilize the movement. ";
    }


    public void onClickBreaststroke()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.arms)
            text.text = "The arm motion is separated into two phases: the pull and the recovery. \r\n    Pull \r\nThe pull is powered by the strongest muscles of the upper body: the latissimus dorsi and the pectorals. These large muscles provide power and endurance. The shoulder muscles are used to make sure the arm movement is precise and controlled. The deltoids control shoulder flexion and rotation and the rotator cuff muscles stabilize the shoulder joint. The forearm muscles are used to keep the wrists stable to apply even pressure against the water. The biceps and triceps control the movement of the elbow. All these smaller muscles are key to the pull since they support the latissimus dorsi and the pectorals. \r\n   Recovery \r\nRecovery in breaststroke is unique because it is done with the arms staying under water, which can be tricky since that creates a lot of drag if it isn’t done efficiently. The deltoids lift and bring the arms forward with the help of the pectorals. The trapezius and rhomboids stabilize the shoulder blades. The triceps extend the elbow as the arms go forward while the bicep and forearm muscles stabilize the movement and control its speed. ";
    }

    public void onClickButterfly()
    {
        if (image.gameObject.activeSelf && bodyPart == ClickTorso.Body.arms)
            text.text = "The arm stroke in butterfly can be split into four phases just like freestyle and backstroke \r\n    Hand Entry  \r\n   Catch  \r\n   Pull   \r\n    Recovery  \r\nEach phase involves a different set of muscles:  \r\n    Hand entry  \r\nThe shoulder blades muscles position the arms for a great catch and a great pull. To stabilize the hands and keep them in the best position, the swimmer uses the multiples muscles in the wrist. \r\n    Catch  \r\nThe latissimus dorsi and the pectorals begin to press downward on water. The shoulder muscles and rotator cuff muscles stabilize the shoulder joint and support the shoulder adduction. The bicep and the forearm flexors help to maintain the forearm and the wrist in an efficient position.\r\n   Pull  \r\nDuring the pull, nearly every muscle in the upper body work, but the latissimus dorsi and the pectorals are the primary muscles. They bring the arms backward while pushing as much water as possible towards the hips. The triceps are used to stabilize the elbow during most of the pull and to increase hand speed at the end of the pull. The deltoids, biceps and core muscle also contribute to the movement. \r\n   Recovery   \r\nAs the arms exit the water, the deltoids lift and recover the arms forward above the water. The trapezius, rhomboids and rotator cuff muscles stabilize and control the motion. ";
    }
}
