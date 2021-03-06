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
- Awake():当一个脚本被实例化时，Awake 被调用，一般在此函数中初始化变量  
- Start()：仅在 Update 函数第一次被调用前调用。因为它是在 Awake 之后被调用的，我们可以把一些需要依赖 Awake 的变量放在Start里面初始化  
- Update()：当开始游戏时，Update 在每一帧被调用一次  
- LateUpdate()：在Update函数调用后紧接被调用  
- FixedUpdate()：MonoBehaviour启用时，在每一固定帧被调用  
- OnEnable()：当对象变为可用或激活状态时此函数被调用  
- OnDisable()：当对象变为不可用或非激活状态时此函数被调用  
- OnGUI(): 绘制GUI时候用到，一般在此函数里绘制GUI  
### 四. 查找脚本手册，了解GameObject，Transform，Component对象 ###  
#### 4.1 分别翻译官方对三个对象的描述(Description) ####  
- GameObject: 游戏对象是Unity中的基本对象，它们代表着角色，道具和场景。虽然它们不能单独靠自己组成游戏，但是它们扮演着一种容器的角色，作为能够实现真正功能的组件的容器。  
- Transform: 这些转换组件决定了游戏中每个对象的位置，旋转和在场景中的比例。每一个游戏对象都有专属的转换组件。  
- Component: 组件是一个游戏中的各个对象和其行为的细致描述。它们是每个游戏对象中的功能成分。  
#### 4.2 描述下图中table对象(实体)的属性、table的Transform的属性、table的部件 ####  
![avatar](https://github.com/MockingT/3D_Game-1/blob/master/picture/3d-example4.png)  
- table对象的属性: table的对象是GameObject，第一个选择框是activeSelf属性。其中tag，layer，Prefab是其三种属性。  
- table的Transform属性: Position(位置)，Scale(大小)，Rotation(选择角度)  
- table的部件: 分别为Mesh Filter & Box Collider & Mesh Renderer  
### 五. 整理相关学习资料，编写简单代码验证以下技术的实现 ###  
- 查找对象/添加子对象/遍历对象树/清除所有子对象  
![avatar](https://github.com/MockingT/3D_Game-1/blob/master/picture/3d-example5.png)  
### 六. 资源预设（Prefabs）与 对象克隆 (clone) ###  
- 预设（Prefabs）有什么好处？  
预设作为组件的集合体 , 预制物体可以实例化成游戏对象，可以重复的创建具有相同结构的游戏对象。并且当组件的属性改变，可以一起改变预设实例化的对象，简化步骤。  
- 预设与对象克隆 (clone or copy or Instantiate of Unity Object) 关系？  
克隆游戏对象需要场景中有被克隆对象，而创建预制只需事先创建预制即可，允许场景中一开始并不存在该游戏对象。克隆出来的游戏对象并不会随着被克隆体的变化而发生变化，但是使用预制创建出来的对象会随着预制的改变而发生改变。
- 制作 table 预制，写一段代码将 table 预制资源实例化成游戏对象  
![avatar](https://github.com/MockingT/3D_Game-1/blob/master/picture/3d-example6.png)  
### 七. 尝试解释组合模式（Composite Pattern / 一种设计模式） ###  
- 组合模式：  
将对象合成树形结构以表示“部分-整体”的层级结构，组合模式使得用户对单个对象和组合对象的使用具有一致性。  
- 使用 BroadcastMessage() 方法向子对象发送消息  
![avatar](https://github.com/MockingT/3D_Game-1/blob/master/picture/3d-example7.png) 
