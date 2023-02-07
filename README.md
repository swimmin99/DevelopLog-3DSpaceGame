<div align="center">
  
![header](https://capsule-render.vercel.app/api?type=rect&height=250&color=auto&text=3D%20Space%20Shotting%20Study&fontColor=auto)
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=UNITY&fontColor=000000&fontSize=20)
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=2022.1.12~2022.1.24&fontColor=000000&fontSize=15)
  
<div align="left">

```
  📌  최종 목표 : 수업 시간에 만들었던 기본 슈팅 게임에 살을 붙여보자.
  ☑️  유형 : 개인 프로젝트
  ☑️  사용 기술 : C#, Unity, Blender
  💡  기대 : 자유롭게 새로운 기능을 추가해보자.
```
  
<div align="center">
<br>
  
  ![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=DEV%20SCHEDULE&fontColor=000000&fontSize=15)

  
 
|날짜|차시|로그|참고자료(Credits)|코드|
|---|---------|---------|----|-----|
|2023-01-21|1|BuildingGeneration| [Module base Random Building Generation](https://www.youtube.com/watch?v=EWnLKpkJzVQ)<br>[3DModuleByKenny](https://www.kenney.nl/assets/modular-buildings)|
|2022-01-28|2|PerlinNoise|[Article1](https://www.scratchapixel.com/lessons/procedural-generation-virtual-worlds/procedural-patterns-noise-part-1/introduction.html) <br> [Article2](https://www.scratchapixel.com/lessons/procedural-generation-virtual-worlds/perlin-noise-part-2/perlin-noise.html)||
|2022-01-29|3|PlayerController|[Matt MirrorFish's Procedural City](https://www.youtube.com/watch?v=LHBR1Jfoh74&t=131s)|[BuildingClusterGenerator](https://github.com/swimmin99/PrivateStudy-AutoGeneration/blob/main/BuildingGeneratorNoiseInput.cs)<br>[GridSpawner](https://github.com/swimmin99/PrivateStudy-AutoGeneration/blob/main/GridSpawner.cs)|

  
  <br>
  
  ![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=DEV%20LOG&fontColor=000000&fontSize=15)

  
---
</div>
<div align="left">

<u><strong>단일 빌딩 블록 생성 (Single Building Generation)</strong></u>
  

```
📌목표 : 모듈화 된 모델들을 이용하여 랜덤한 모습의 빌딩을 생성한 후 이를 도시의 모습으로 배치하기
세부목표1 : 랜덤하게 모듈을 합체하는 스크립트를 만들 것.
세부목표2 : 만든 도시를 랜덤한 블록으로 생성하는 스크립트를 만들 것.
```

  
<div align="center">
  <img src ="https://user-images.githubusercontent.com/109887066/217244364-42996ad8-f319-4799-a640-8546a8c04f2c.png" width="100%" height="100%"/>
  
  ```스페이스 바를 누르면(ButtonDown)레이저가 계속해서 발생하고 한번 더 누르면(ButtonDown) 레이저가 꺼지는 형식```


|쉐이더적용전|쉐이더적용후|
|-----------|-----------|
|<div align="center"><img src ="https://user-images.githubusercontent.com/109887066/217244854-a2b1473d-6bb8-4d02-b13f-cf5d33bf88f6.png"/>|<div align="center"><img src ="https://user-images.githubusercontent.com/109887066/217244857-2828c378-b8a0-4366-a826-0b44c18da69a.png"/>|

  ```간단한 쉐이더를 카메라에 적용해 레트로 게임의 느낌이 들도록 해 보았다.```


   <img src ="https://user-images.githubusercontent.com/109887066/217245145-e6820083-a448-4dbe-854c-160b60c17fae.gif" width="50%" height="50%"/>

  ```우주선의 레이저가 단발로 나가도록 만들어보았다.```<br> 
  
    <img src ="https://user-images.githubusercontent.com/109887066/217245311-3bdc64f2-21a5-4131-b7ad-153dd3443bb4.gif" width="60%" height="60%"/>

  ```충돌 시 폭발 이펙트가 나도록 하고 우주선이 회전하다가 원래의 rotation으로 돌아오도록 만들었다.```  
  
    <img src ="https://user-images.githubusercontent.com/109887066/217245805-68520b04-3a52-4de6-90d6-1b1b1098060e.gif" width="60%" height="60%"/>
    <img src ="https://user-images.githubusercontent.com/109887066/217245796-19aa7413-009d-41cc-9cb5-46329f5a5458.gif" width="60%" height="60%"/>

  ```충돌 시 운석이 쪼개지는 효과를 내기 위해 blender의 add on 기능을 사용해 조각난 운석 모델을 만들었다.```
    
    <img src ="https://user-images.githubusercontent.com/109887066/217246186-3681f227-83b8-49ae-9c3f-1e20a610d2ac.gif" width="60%" height="60%"/>

  ```충돌 시 원래 운석 오브젝트는 사라지면서 조각난 운석 오브젝트 프리팹을 Instantiate 하는 방법을 사용하였다.```
      
    <img src ="https://user-images.githubusercontent.com/109887066/217246440-bcc10fff-dbc9-4bfb-92dc-dda1723bd359.gif" width="60%" height="60%"/>

  ```다중 카메라를 사용하여 시점을 바꾸는 것을 추가해 보았다.```
  


<div align="left">


```
💡발전한 점


📝앞으로의 방향

```
  
  
---

    
```
💡느낀점 : 
```
  
