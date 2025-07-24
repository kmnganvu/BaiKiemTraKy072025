namespace TestMVC.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
// dotnet aspnet-codegenerator controller -name YourController -m YourModel -dc YourNamespce.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
// Trong đó:
// YourController: là tên controller muốn đặt (ví dụ EmployeeController)
// YourModel: là tên class trong Model (ví dụ Employee)
// ApplicationDbContext: là file trong thư mục Data ở slide 41. Cấu hình kết nối và làm việc với CSDL
// YourNamespace: là tên namespace của file ApplicationDbContext trong project (Ví dụ MvcMovie.Data).
// dotnet aspnet-codegenerator identity -dc VicemMVCIdentity.Data.ApplicationDbContext -f sinh bổ sung mã nguồn cho Identity
// dotnet aspnet-codegenerator identity -dc VicemMVCIdentity.Data.ApplicationDbContext --files "Account.Register;Account.Login;Account.Logout"


