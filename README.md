# 進擊的韭菜

## 情境描述
幣圈裡面，有一種暱稱叫做 `韭菜` 的生物，如果你想要低價買入他們手上的比特幣，放出一些恐慌訊息，他們馬上就會賣掉；相反的，如果你想要高價賣出你手上的囤貨，你只要放出利好消息，他們就會蜂蛹買入。

## 輸入說明

- 第一行有一個整數 N (N <= 999,999,999,999)，代表有 n 個韭菜由左至右排成一排，這些韭菜手上都持有比特幣，由最左邊的韭菜開始編號： 1, 2, 3, ..., N。
- 第二行有一整數 M (M <= 999999)，接下來會有 M 次割韭菜的行為。
- 接下來 M 行每行有兩個整數 i~ j，表示對從 i 到 j 的這堆韭菜進行收割。(i、j設定由程式隨機自動產出，原因請見解題思路說明)

## 輸出說明

請輸出最後有多少韭菜還沒有賣掉比特幣？

## 範例輸入

```c
5 // N
3 // M
1~3 // [i, j]  
3~5 // [i, j] 
1~5 // [i, j] 
(i、j設定由程式隨機自動產出，原因請見解題思路說明)
```

## 範例輸出

```bash
4
```

## 解題思路

從範例輸入跟輸出，可以推得韭菜被收割次數若是奇數次就是賣掉比特幣了，偶數次就是沒有賣掉  
```c
1~3 => [1, 2, 3]  
3~5 => [3, 4, 5]  
1~5 => [1, 2, 3, 4, 5] 
```
統計被收割次數  
- 韭菜1號: 2次
- 韭菜2號: 2次
- 韭菜3號: 3次
- 韭菜4號: 2次
- 韭菜5號: 2次  
偶數次表示沒有賣掉，所以有4個韭菜沒賣掉  

程式碼邏輯  
- 程式碼一開始請使用者輸入韭菜人數(N)、割韭菜次數(M)，至於每次割韭菜的韭菜範圍，就用隨機變數由程式自動產出，避免若M過大，將導致割韭菜的韭菜範圍輸入值過於冗長  
- 接著將割韭菜的範圍用list泛型集合來呈現韭菜集合，並搭配linq的query expression語法計算各個韭菜被收割的次數  
- 最後即可挑選出沒賣掉比特幣(被收割次數偶數次)的韭菜人數  

## 執行方法

請使用者輸入韭菜人數(N)、割韭菜次數(M)，即可得到沒賣掉比特幣的韭菜人數之結果
