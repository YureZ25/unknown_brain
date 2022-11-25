# Unknown Brain

> Do follow commands at BE solution path `./UB/BE`

### Entity Framework Migration Init

Don't forget install ef tools `dotnet tool install --global dotnet-ef`

### Remove migration

At BE solution path: `dotnet ef migrations remove -p "UB.Data" -s "UB.API"`

### Add migration

At BE solution path: `dotnet ef migrations add <name of your migration> -p "UB.Data" -s "UB.API"`

### Apply migration to DB

At BE solution path: `dotnet ef database update -p "UB.Data" -s "UB.API"`

### Serve Development App

> Do follow commands at FE solution path `./UB/FE/ub`

```
npm run start
```

### Build Production App

```
npm run build
```
### Run SQL scripts

> Don't forget add psql to PATH

Run from root of project: `psql -U postgres -d ub -f .\BE\UB.Data\SqlScripts\<script_name>`