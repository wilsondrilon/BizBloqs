# BizBloqs

BizBloqs Installation guide

## Installation

1.) Install the following if not yet on the machine.

[Git](https://git-scm.com/)

[Visual Studio](https://visualstudio.microsoft.com/)

[MSSQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

[Postman](https://www.postman.com/)

2.) Clone BizBloqs repo.

```bash
git clone https://github.com/wilsondrilon/BizBloqs.git
```

3.) Check your **appsettings.Development.json** connection string value. Should match your database instance

![alt text](https://raw.githubusercontent.com/wilsondrilon/BizBloqs/develop/ScreenshotGuide/appsettings_guide.png)

4.) Set you **Default Project:** on **Package Manager Console** Window to be set to **BizBloqs.Entity**

![alt text](https://raw.githubusercontent.com/wilsondrilon/BizBloqs/develop/ScreenshotGuide/packageManagerConsole_guide.png)

5.) Run this command to set the local environment variable on **Package Manager Console**
```shell
PM> $env:ASPNETCORE_ENVIRONMENT="Development"
```
6.) Run this command on **Package Manager Console** to initialize database migration
```shell
PM> Update-Database
```

7.) Run this command on **Package Manager Console** to execute unit test or can be done on **Test Explorer** as desired.
```shell
PM> dotnet test
```

8.) Run the project
```
F5
```


## API Usage

**POST -  Word**

Insert single data on the database.

* **URL**

   `/api/v1/word`

* **Method:**
  
  `POST`

* **Data Params**

  [REQUIRED]

  `data=[string]`

```
Sample Json:
{
   "data":"BizBloqs"
}
```

* **Success Response:**
   
```
Code: 200 OK
Response:
{
    "isSuccessful": true,
    "statusCode": 200,
    "message": "Data Inserted!",
    "data": null
}
```
 
* **Error Response:**

```
Code: 400 BAD REQUEST
Response:
{
    "isSuccessful": false,
    "statusCode": 400,
    "message": "Provided data is invalid, Value must not be null, empty or whitespace",
    "data": null
}
```
---
**GET -  Vowels**

Get all the vowels from the fetched data on the database.

* **URL**

   `/api/v1/word/vowel`

* **Method:**
  
  `GET`

* **Success Response:**
   
```
Code: 200 OK
Response:
{
    "isSuccessful": true,
    "statusCode": 200,
    "message": "Data has been generated!",
    "data": {
        "textList": [
            {
                "storeTextId": 2,
                "data": "BizBloqs",
                "createdOn": "2021-01-26T20:06:39.8893521"
            },
            {
                "storeTextId": 4,
                "data": "Rabit",
                "createdOn": "2021-01-26T20:06:50.4282508"
            }
        ],
        "totalVowels": 4
    }
}
```

## License
[MIT](https://choosealicense.com/licenses/mit/)
