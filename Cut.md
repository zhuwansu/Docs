# 说明
日志记得很大，好几个 G 打不开，很难受。

想下载个工具切割一下，找不到简单好用的，找到了代码，没找到编译好的，很难受。

代码抄过来，改吧改吧，编译出来放在这里，非常的简单方便!!!

## 文件下载

> - [cut.exe](tools/CutRelease/Cut.exe "切割文件小工具")  
> - [log.txt](tools/CutRelease/log.txt "测试使用的日志文件")  
> - [demo.cmd](tools/CutRelease/test.cmd "演示用的 bat 命令")  

## 使用说明

1. 把 cut.exe 粘贴到要拆分文件 log.txt 所在目录下
2. 新建一个 cmd 如下：

```` cmd 
::cut arg1 arg2 
cut log.txt 1 
````
或者在地址栏输入 cmd 回车 弹出终端手动输入

3. 生成文件 cut log.txt_s /log_n.txt 1m

### 参数说明
> cut arg1 arg2 
1. arg1：必选，目标文件，单个文件
2. arg2：可选，输出文件大小，单位 m，默认 200 m

