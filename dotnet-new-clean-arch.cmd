dotnet new sln --name CleanArch
dotnet new webapi -o CleanArch.Api
dotnet new classlib -o CleanArch.Domain
dotnet new classlib -o CleanArch.Data
dotnet new classlib -o CleanArch.Infra
dotnet new classlib -o CleanArch.Shared
dotnet new xunit -o CleanArch.Tests

dotnet sln add CleanArch.Api/CleanArch.Api.csproj

dotnet sln add CleanArch.Domain/CleanArch.Domain.csproj
dotnet sln add CleanArch.Data/CleanArch.Data.csproj
dotnet sln add CleanArch.Infra/CleanArch.Infra.csproj
dotnet sln add CleanArch.Shared/CleanArch.Shared.csproj
dotnet sln add CleanArch.Tests/CleanArch.Tests.csproj

dotnet add CleanArch.Api/CleanArch.Api.csproj reference CleanArch.Domain/CleanArch.Domain.csproj
dotnet add CleanArch.Api/CleanArch.Api.csproj reference CleanArch.Data/CleanArch.Data.csproj
dotnet add CleanArch.Api/CleanArch.Api.csproj reference CleanArch.Infra/CleanArch.Infra.csproj
dotnet add CleanArch.Api/CleanArch.Api.csproj reference CleanArch.Shared/CleanArch.Shared.csproj

dotnet add CleanArch.Tests/CleanArch.Tests.csproj reference CleanArch.Domain/CleanArch.Domain.csproj
dotnet add CleanArch.Tests/CleanArch.Tests.csproj reference CleanArch.Data/CleanArch.Data.csproj
dotnet add CleanArch.Tests/CleanArch.Tests.csproj reference CleanArch.Infra/CleanArch.Infra.csproj
dotnet add CleanArch.Tests/CleanArch.Tests.csproj reference CleanArch.Api/CleanArch.Api.csproj


dotnet add CleanArch.Data/CleanArch.Data.csproj reference CleanArch.Domain/CleanArch.Domain.csproj
dotnet add CleanArch.Infra/CleanArch.Infra.csproj reference CleanArch.Domain/CleanArch.Domain.csproj

dotnet add CleanArch.Infra/CleanArch.Infra.csproj reference CleanArch.Data/CleanArch.Data.csproj

cd CleanArch.Infra
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
cd ..

dotnet tool install --global dotnet-ef