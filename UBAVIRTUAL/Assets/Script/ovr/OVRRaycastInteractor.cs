using UnityEngine;

public class OVRRaycastInteractor : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float rayLength = 20f;
    public LayerMask layerInteractivo;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        lineRenderer.SetPosition(0, transform.position);

        if (Physics.Raycast(ray, out hit, rayLength, layerInteractivo))
        {
            lineRenderer.SetPosition(1, hit.point);

            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                CambiarEscenaOculus cambiar = hit.collider.GetComponent<CambiarEscenaOculus>();
                if (cambiar != null)
                {
                    cambiar.Cambiar();
                }
            }
        }
        else
        {
            lineRenderer.SetPosition(1, transform.position + transform.forward * rayLength);
        }
    }
}
