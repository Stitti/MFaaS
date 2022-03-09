# Getting started

## Shell
```shell
curl https://mfaas.herokuapp.com/api/quotes/random
```

## PowerShell
```powershell
Invoke-WebRequest -URI https://mfaas.herokuapp.com/api/quotes/random
```
```text
StatusCode        : 200
StatusDescription : OK
Content           : {"quote":"Just because he's behind a curtain doesn't make him a wizard.","actor":"Claire Dunphy"}
RawContent        : HTTP/1.1 200 OK
                    Connection: keep-alive
                    Transfer-Encoding: chunked
                    Content-Type: application/json; charset=utf-8
                    Date: Wed, 09 Mar 2022 14:02:06 GMT
                    Server: Kestrel
                    Via: 1.1 vegur

                    {"quote":"Ju...
Forms             : {}
Headers           : {[Connection, keep-alive], [Transfer-Encoding, chunked], [Content-Type, application/json;
                    charset=utf-8], [Date, Wed, 09 Mar 2022 14:02:06 GMT]...}
Images            : {}
InputFields       : {}
Links             : {}
ParsedHtml        : mshtml.HTMLDocumentClass
RawContentLength  : 97
```

## C#
```cs
  HttpClient client = new HttpClient();
  HttpResponseMessage response = await client.GetAsync("https://mfaas.herokuapp.com/api/quotes/random");
  response.EnsureSuccessStatusCode();
  string responseBody = await response.Content.ReadAsStringAsync();
```