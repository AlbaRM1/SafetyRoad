using UnityEngine;

namespace CubePeople
{
    public class AnimationController : MonoBehaviour
    {
        public FixedJoystick Joystick;

        public string AnimName;

        public Animator anim;
        public float run;

        void Start()
        {
            anim = GetComponent<Animator>();
            if (run == 1f) run = 0f;
        }


        void Update()
        {

            if (Joystick.Horizontal != 0 || Joystick.Vertical != 0)
            {
                run = 1f;
            }
            else
            {
                run = 0f;
            }

            anim.SetFloat(AnimName, run);
        }
    }
}
