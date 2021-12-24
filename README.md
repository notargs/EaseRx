# EaseRx
EaseRx is UniRx friendly simple easing library.

## Using
Add this snippet to package manager.
```json
"com.notargs.easerx": "https://github.com/notargs/EaseRx.git?path=/Assets/EaseRx#v1.0.2"
```

## Example

### Ease from (-1, 0, 0) to (1, 1, 0) by easeInQuad
```cs
Ease(TimeSpan.FromSecond(1.0f)).FromTo(new Vector3(-1, 0, 0), new Vector3(1, 1, 0)).EaseInQuad().Subscribe(_ => {}).AddTo(this)
```

## License
This library is under the MIT License.
