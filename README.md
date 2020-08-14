Requirements docker is needed to run this project.

[Docker Install](https://docs.docker.com/docker-for-mac/install/)

Run the following `docker-compose up` from the project root directory.

Use Postman to issue the following REST API calls.

#### POST http://localhost/Settings

With the follwoing request payload.

```
{
    "id": "ab76b8c0-e98b-4b6b-b86a-e458a5bf2b81",
    "category": 1,
    "name": "Setting7",
    "value": null,
    "type_id": 2
}
```

#### GET http://localhost/Settings

Returns the following response payload.

```
[
    [
    {
        "id": "775bd791-85be-40e6-bfad-35d98559ce9c",
        "category": 1,
        "name": "Setting1",
        "value": "Value1",
        "type_id": 1
    },
    {
        "id": "775bd791-85be-40e6-bfad-35d98559ce9c",
        "category": 1,
        "name": "Setting2",
        "value": "10",
        "type_id": 2
    },
    {
        "id": "775bd791-85be-40e6-bfad-35d98559ce9c",
        "category": 2,
        "name": "Setting3",
        "value": "true",
        "type_id": 3
    },
    {
        "id": "775bd791-85be-40e6-bfad-35d98559ce9c",
        "category": 2,
        "name": "Setting4",
        "value": "2020-06-03T00:00:00",
        "type_id": 4
    },
    {
        "id": "775bd791-85be-40e6-bfad-35d98559ce9c",
        "category": 2,
        "name": "Setting5",
        "value": "{name1:\"value\",name2:2,name3:true,name4:null}",
        "type_id": 5
    },
    {
        "id": "ab76b8c0-e98b-4b6b-b86a-e458a5bf2b81",
        "category": 1,
        "name": "Setting7",
        "value": null,
        "type_id": 2
    }
]
]
```