`Svelto.ECS` 一个简单的入门,如果你是它的使用者,看到了这篇文章发现了错误的地方,希望您指出(`1375400884@qq.com`),谢谢!

作者博客:[sebaslab](http://www.sebaslab.com/)

下面的例子使用版本说明:
- `Svelto.ECS`版本为`2.8`,提交记录为[1a165d736b7e6a0dbf21a119f49918665f88e6cd](https://github.com/sebas77/Svelto.ECS/commit/1a165d736b7e6a0dbf21a119f49918665f88e6cd)马上出`2.9`
- `Svelto.Tasks`提交记录为[c40b5b9552264b310b1abfb2202fdfb6b235ebf9](https://github.com/sebas77/Svelto.Tasks/commit/c40b5b9552264b310b1abfb2202fdfb6b235ebf9)
- `Svelto.Common`提交记录为[433b39f4a1b9a17301988ecd8a633d049bb4378d](https://github.com/sebas77/Svelto.Common/commit/433b39f4a1b9a17301988ecd8a633d049bb4378d)

[Demo地址,运行游戏,点击屏幕即可](https://github.com/yika-aixi/Svelto.ECS-Hello-World-Demo)

##### **闲话**:

如果您有一些其他ECS的知识,可能会发现该ECS和你碰过的ECS都不一样.

`Svelto.ECS` 中 `S` 是 `Engine` 而 `C` 和 `E` 这2个比较混乱,为什么这么说,等会您就知道. 

`Svelto.ECS`的作者从他博客我看出他应该是被依赖注入给恶心过,但又很喜欢依赖注入的方式,所以在`Svelto.ECS`里`依赖注入`会经常看到

### **开始**:

首先在Demo中你会看到这些文件夹
- Descriptor : ECS中的 E ,您看文档理解吧=-=[地址](http://www.sebaslab.com/svelto-ecs-2-5-and-allocation-0-code/). 实体的描述,删除和创建实体
- Engine : ECS中的 S. 逻辑
- EntityStruct : ECS中的 E 但又表现的像C,为什么我会这么说,看这篇[wiki](https://github.com/sebas77/Svelto.ECS/wiki/Beyond-EntityDescriptor%3A-polymorphic-and-dynamic-EntityDescriptor)
- EntityViewStruct 就是`EntityStruct`的另外一种写法
- Implementor : 按照作者的意思是一些具体的引擎逻辑则编写`Implementor`,Demo中`DebugLog`就是一个例子
- GameMain : 游戏入口,作者说的`Composition Root`,将进行`Svelto.ECS`的初始化,代码很简单,但是有个地方需要注意`EnginesRoot`对象一定要弄成字段或属性,否则会被回收

快速的例子编写顺序
```
1. 创建 `EntityViewStruct` 或者 `EntityStruct`
2. 创建 `MessageEntityDescriptor`
3. 创建 `Engine`
```

到此结束.不知道能否看的懂么=-=,在下文笔水平有限,见谅=-=

放一张运行结果
<img src="https://github.com/yika-aixi/Svelto.ECS-Hello-World-Demo/blob/master/Images/console.png" />