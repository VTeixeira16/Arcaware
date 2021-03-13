using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeController : MonoBehaviour
{
    [SerializeField] public static FadeController _instanciaFade;

    [SerializeField] private Image _imagemFade;
    [SerializeField] private Color _corInicial, _corFinal;
    [SerializeField] private float _duracaoFade;
    // [SerializeField] private bool _isFade;

    private float _tempo;

    void Awake()
    {
        _instanciaFade = this;
    }

    IEnumerator inicioFade()
    {
        //_isFade = true;
        _tempo = 0f;

        while (_tempo <= _duracaoFade)
        {
            _imagemFade.color = Color.Lerp(_corInicial, _corFinal, _tempo / _duracaoFade);
            _tempo = _tempo + Time.deltaTime;
            yield return null;
        }

        // _isFade = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(inicioFade());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
