using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitcher : MonoBehaviour
{
    public GameObject[] mButtonsMeshes;
    public GameObject mMainMesh;
    public float mRotationSpeed;
    private int mCountOfPressedButtons;
    private bool mIsRotation = false;
    private float mRotatedAngle = 0.0f;

    void Start()
    {
        mCountOfPressedButtons = 0;
    }

    void Update()
    {
        if (mCountOfPressedButtons == mButtonsMeshes.Length)
        {
            mIsRotation = true;
            mCountOfPressedButtons = 0;
        }

        if (mIsRotation && mRotatedAngle < 180.0f)
        {
            float step = 180.0f / (mRotationSpeed / Time.deltaTime);

            if (mRotatedAngle + step > 180.0f)
                mMainMesh.transform.Rotate(180.0f - mRotatedAngle, 0, 0);
            else
                mMainMesh.transform.Rotate(step, 0, 0);

            mRotatedAngle += step;
        }

        if (mRotatedAngle >= 180.0f)
        {
            mIsRotation = false;
            mRotatedAngle = 0.0f;

            for (int i = 0; i < mButtonsMeshes.Length; i++)
            {
                mButtonsMeshes[i].GetComponent<SphereCollider>().enabled = true;
            }
        }
    }

    public void Switch(int index)
    {
        if (mButtonsMeshes[index].GetComponent<SphereCollider>().enabled == true)
        {
            mButtonsMeshes[index].transform.Rotate(new Vector3(180, 0, 0));
            mButtonsMeshes[index].GetComponent<SphereCollider>().enabled = false;
            mCountOfPressedButtons++;
            ScoreCounter.Instance.Count();
        }
    }
}
