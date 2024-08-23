# Positional records and Data annotations

1. Install .NET 9
2. `dotnet new webapi -controllers --exclude-launch-settings --no-restore`
3. change code as seen in first commit
4. dotnet run
5. observe results:
   1. OpenAPI document at `http://localhost:5000/openapi/v1.json`
   2. POSTing

      ```bash
      curl -H "Content-Type: application/json" -d '{"payload":"Too long"}' -X POST http://localhost:5000/normalnoopenapi
      curl -H "Content-Type: application/json" -d '{"payload":"Too long"}' -X POST http://localhost:5000/good
      curl -H "Content-Type: application/json" -d '{"payload":"Too long"}' -X POST http://localhost:5000/noopenapi
      curl -H "Content-Type: application/json" -d '{"payload":"Too long"}'-X POST http://localhost:5000/nogood
      curl -H "Content-Type: application/json" -d '{"payload":"Too long"}' -X POST http://localhost:5000/novalidation
      ```
