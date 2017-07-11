<Query Kind="Expression">
  <Connection>
    <ID>d5009e00-d3fa-4bc8-8e2a-4cf0f5cdaddb</ID>
    <Persist>true</Persist>
    <Driver Assembly="JsonDataContextDriver" PublicKeyToken="ed22602f98bb09d6">JsonDataContextDriver.JsonDynamicDataContextDriver</Driver>
    <DisplayName>Serilog Samples</DisplayName>
    <DriverData>
      <inputDefs>{"$type":"System.Collections.Generic.List`1[[JsonDataContextDriver.IJsonInput, JsonDataContextDriver]], mscorlib","$values":[{"$type":"JsonDataContextDriver.JsonTextInput, JsonDataContextDriver","InputGuid":"4fe65eb5-e6f0-49d5-9ce5-4239eeacd6b0","Name":"Person","Json":"{\"Timestamp\":\"2017-07-11T16:34:17.5958685+02:00\",\"Level\":\"Information\",\"MessageTemplate\":\"Created {@User} on {Created}\",\"Properties\":{\"User\":{\"_typeTag\":\"User\",\"Id\":1,\"Name\":\"Adam\",\"Birthday\":\"0001-01-01T00:00:00.0000000\"},\"Created\":\"2017-07-11T16:34:17.5958685+02:00\"}}"},{"$type":"JsonDataContextDriver.JsonTextInput, JsonDataContextDriver","InputGuid":"86dfdc75-d3a4-44d0-ae77-587a49f85b65","Name":"PersonEnriched","Json":"    {\r\n        \"Timestamp\":\"2017-07-11T16:34:17.5958685+02:00\",\r\n        \"Level\":\"Information\",\r\n        \"MessageTemplate\":\"Created {@User} on {Created}\",\r\n        \"Properties\":{\r\n            \"User\":{\r\n                \"_typeTag\":\"User\",\r\n                \"Id\":1,\r\n                \"Name\":\"Adam\",\r\n                \"Birthday\":\"0001-01-01T00:00:00.0000000\"\r\n            },\r\n            \"Created\":\"2017-07-11T16:34:17.5958685+02:00\",\r\n            \"DayOfWeek\":\"Tuesday\"\r\n        }\r\n    }"}]}</inputDefs>
    </DriverData>
  </Connection>
</Query>

/*
    {
        "Timestamp":"2017-07-11T16:34:17.5958685+02:00",
        "Level":"Information",
        "MessageTemplate":"Created {@User} on {Created}",
        "Properties":{
            "User":{
                "_typeTag":"User",
                "Id":1,
                "Name":"Adam",
                "Birthday":"0001-01-01T00:00:00.0000000"
            },
            "Created":"2017-07-11T16:34:17.5958685+02:00",
            "DayOfWeek":"Tuesday"
        }
    }
*/

PersonEnriched.Take (100)