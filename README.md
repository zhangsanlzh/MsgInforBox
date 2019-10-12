## MsgInforBox

弹出一个Metro风格的提示框，一段时间后自动消失。

适用于Winform项目。



> ### 用法

##### 一、弹出默认提示

```c#
MsgInforBox.Show(this, "(ง •_•)ง   请输入账号");
```

##### 二、弹出错误提示

```c#
MsgInforBox.Show(this, "(ง •_•)ง   请输入账号", InforType.Error);
```

##### 三、改变显示时间

```
// 显示5秒，默认显示2秒
MsgInforBox.Show(this, "(ง •_•)ง   请输入账号", InforType.Error, 5);
```



![demo](https://github.com/zhangsanlzh/MsgInforBox/blob/master/images/demo.gif)

