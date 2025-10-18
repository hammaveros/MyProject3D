# MyProject3D

Unity 3D 프로젝트

## 환경 요구사항

- Unity
- Universal Render Pipeline (URP)

## 설치 방법

1. 이 저장소를 클론합니다:
```bash
git clone [저장소 URL]
cd MyProject3D
```

2. Unity Hub에서 프로젝트를 엽니다:
   - Unity Hub 실행
   - "Add" 또는 "열기" 버튼 클릭
   - 클론한 `MyProject3D` 폴더 선택

3. Unity가 자동으로 필요한 패키지와 Library를 생성합니다
   - 처음 열 때 시간이 좀 걸릴 수 있습니다 (몇 분 정도)
   - Library, Temp 등의 폴더가 자동 생성됩니다

## 실행 방법

1. Unity Editor에서 `Assets/Scenes/SampleScene.unity` 씬을 엽니다
2. 상단의 Play 버튼(▶)을 눌러 게임을 실행합니다

## 문제 해결

### Input System 에러가 나는 경우
- Edit → Project Settings → Player → Other Settings
- Active Input Handling을 "Both"로 변경
- Unity 재시작

### Library 폴더 문제
- Library 폴더를 삭제하고 Unity 재시작
- Unity가 자동으로 재생성합니다
