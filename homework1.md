# 简单题
### 一. 游戏对象(GameObjects) 和 资源(Assets)的区别与联系： ###  
- 游戏对象(GameObjects):  
构建游戏的基础单元，通过在特定场景中进行交互来完成游戏过程。游戏对象是组件（Component）的容器，单个游戏对象通常包含多于一个组件，同时也可以包含其他游戏对象作为其子对象。
- 资源(Assets):  
表示材质、纹理、音频文件、游戏对象等在开发过程中可使用的资源。
- 区别:  
游戏对象是直接构成游戏过程的基础单元，而资源是供选择的各种元素的总称  
- 联系:  
游戏对象建立在资源的基础上，资源为游戏对象提供了材料  
### 二. 分别总结资源、对象组织的结构（指资源的目录组织结构与游戏对象树的层次结构): ###  
- 下载2D UFO Tutorial资源的目录组织结构和游戏对象属如下，资源中有多个存放图片，脚本等的文件:  
![avatar](https://github.com/MockingT/3D_Game-1/blob/master/picture/3d-example.png)  
### 三. 编写一个代码，使用 debug 语句来验证 MonoBehaviour 基本行为或事件触发的条件:  ###  
- 测试代码如下图：  
![avatar](https://github.com/MockingT/3D_Game-1/blob/master/picture/3d-example3.png)  
- 测试结果如下图：  
![avatar](https://github.com/MockingT/3D_Game-1/blob/master/picture/3d-example2.png)  
- MonoBehaviour中每个函数的功能和执行时间:  
- Awake()
