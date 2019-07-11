## 文件下载

> [cut](tools/CutRelease/Cut.exe "cut.exe")
> [log](tools/CutRelease/log.txt "log.txt")
> [demo](tools/CutRelease/test.cmd "test.cmd")

## 使用说明

1. 把 cut.exe 粘贴到要拆分文件 log.txt 所在目录下
2. 新建一个 cmd 如下：

```` cmd 
cut log.txt 1 
````
或者在地址栏输入 cmd 回车 弹出终端手动输入
3. 生成文件 cut log.txt_s /log_n.txt 1m

## 参数说明

1. arg1:目标文件,单个文件
2. arg2:分割大小,单位 m

