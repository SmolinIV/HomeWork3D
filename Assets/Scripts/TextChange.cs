using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    private const int _replacementCommandCode = 0;
    private const int _additionCommandCode = 1;
    private const int _huckingCommandCode = 2;

    [SerializeField] private int _duration;
    [SerializeField] private Text _text;
    [SerializeField] private string _textForReplace;
    [SerializeField] private string _textForAdd;
    [SerializeField] private string _textForHuck;

    private int[] _commandCodes = new int[] { _replacementCommandCode, _additionCommandCode, _huckingCommandCode };

    private string _deafaultText;

    private int _currentCommandCode;
    private float _passedTime;

    private void Start()
    {
        _deafaultText = _text.text;

        _currentCommandCode = 0;
        _passedTime = 0;

        StartNextAction();
    }

    private void Update()
    {
        _passedTime += Time.deltaTime;

        if (_passedTime > _duration)
        {
            _passedTime = 0;
            _currentCommandCode = ++_currentCommandCode % _commandCodes.Length;
            StartNextAction();
        }
    }

    private void StartNextAction()
    {
        bool enableRichText = true;

        switch (_currentCommandCode)
        {
            case _replacementCommandCode:
                _text.text = _deafaultText;

                _text.DOText(_textForReplace, _duration);

                break;

            case _additionCommandCode:
                _text.DOText(_textForAdd, _duration).SetRelative();

                break;

            case _huckingCommandCode:
                _text.DOText(_textForHuck, _duration, enableRichText, ScrambleMode.All);

                break;
        }
    }
}
