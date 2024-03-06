using UnityEngine;

public class ClickRegistrator : MonoBehaviour
{
    [SerializeField] private BallContainer _ballContainer;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.TryGetComponent(out Ball ball))
                {
                    _ballContainer.OnBallClick(ball);
                }
            }
        }
    }
}
