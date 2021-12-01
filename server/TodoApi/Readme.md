# Repository

이 레파지토리는 [Tutorial: Create a minimal web API with ASP.NET Core | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0&tabs=visual-studio) 을 보고 실습한 결과입니다.

## TodoApi

TodoApi는 할 일 목록을 위한 최소 구성의 API입니다.

### 설치

-

### 빌드

위 코드를 다운받아 직접 빌드한다.

### 실행

vscode 에서 ctrl+F5를 눌러서 실행시킨다. runtime 동안 POSTMAN을 사용하여 요청을 보낼 수 있다.

아래는 POST 기능의 예시이다.

+ POSTMAN에서 new request

+ HTTP 메소드를 `POST`로 선택

+ URL을 `https://localhost:<port>/todoitems`로 설정

+ Body 탭에서 raw 선택. JSON 타입.

+ 아래 리퀘스트 바디를 입력.

```json
{
  "name":"walk dog",
  "isComplete":true
}
```

* send.
