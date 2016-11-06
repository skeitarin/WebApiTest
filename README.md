# WebApiTest

## 概要
Ajaxなどのテストを行うためのコード。AzureのWebAppsにデプロイすることで利用することができる。

## 使用例


```javascript

    $.ajax({
        type:"GET",
        url:"http://api-test1106.azurewebsites.net/api/test",    // <-- テスト用URL
        dataType:"jsonp"
    })
    .done(function(data){
        data = JSON.stringify(data);
        alert(data);
    });

```


