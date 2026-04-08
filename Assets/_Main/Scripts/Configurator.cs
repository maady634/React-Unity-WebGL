using UnityEngine;

public class Configurator : MonoBehaviour
{
    [Header("Partss")]
    public MeshRenderer bodyRenderer;
    public MeshRenderer topRenderer;
    public MeshRenderer coverRenderer;
    public MeshRenderer laceRenderer;

    private MaterialPropertyBlock _mpb;

    void Awake()
    {
        _mpb = new MaterialPropertyBlock();
    }

    public void ChangeBody(string hex)
    {
        ApplyColor(bodyRenderer, hex);
    }

    public void ChangeTop(string hex)
    {
        ApplyColor(topRenderer, hex);
    }

    public void ChangeCover(string hex)
    {
        ApplyColor(coverRenderer, hex);
    }

    public void ChangeLace(string hex)
    {
        ApplyColor(laceRenderer, hex);
    }

    [ContextMenu("Apply gloss")]
    public void ChangeToGlossy()
    {
        ApplyFinish(0.2f, 1f);
    }

    [ContextMenu("Apply matte")]
    public void ChangeToMatte()
    {
        ApplyFinish(0f, 0.05f);
    }

    void ApplyColor(MeshRenderer r, string hex)
    {
        if (r == null) return;
        if (ColorUtility.TryParseHtmlString(hex, out Color color))
        {
            r.GetPropertyBlock(_mpb);
            _mpb.SetColor("_BaseColor", color);
            r.SetPropertyBlock(_mpb);
        }
    }

    void ApplyFinish(float metallic, float smoothness)
    {
        foreach (var r in new[] { bodyRenderer, topRenderer, coverRenderer, laceRenderer })
        {
            if (r == null) continue;
            r.GetPropertyBlock(_mpb);
            _mpb.SetFloat("_Metallic", metallic);
            _mpb.SetFloat("_Smoothness", smoothness);
            r.SetPropertyBlock(_mpb);
        }
    }
}