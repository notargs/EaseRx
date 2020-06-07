# EaseRx
EaseRx is UniRx friendly simple easing library.

## Example
`Ease(TimeSpan.FromSecond(1.0f)).FromTo(new Vector3(-1, 0, 0), new Vector3(1, 1, 0)).EaseInQuad().Subscribe(_ => {}).AddTo(this)` 
ease from (-1, 0, 0) to (1, 1, 0) by easeInQuad
