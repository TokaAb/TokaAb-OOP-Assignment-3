using RefactoringLab.Part02.Enrollment;
using RefactoringLab.Part02.Reports;

Console.WriteLine("=== Reports ===");

var outDir = Path.Combine(
    Path.GetTempPath(),
    "refactoring-lab-part02");

Directory.CreateDirectory(outDir);

var csvReport = new CsvReportExporter();


csvReport.Export(Path.Combine(outDir, "report.csv"));

var jsonReport = new JsonReportExporter();
jsonReport.Export(Path.Combine(outDir, "report.json"));

var textReport = new TextReportExporter();
textReport.Export(Path.Combine(outDir, "report.txt"));

Console.WriteLine($"Wrote reports to {outDir}");
Console.WriteLine();

Console.WriteLine("=== Enrollment ===");

var studentId = "S100";
var courseId = "CS201";
var amount = 1500m;

var enrollment = new EnrollmentFacade(
    new PaymentGateway(),
    new SeatInventory(),
    new InvoiceGenerator(),
    new EmailService());

enrollment.Enroll(studentId, courseId, amount);