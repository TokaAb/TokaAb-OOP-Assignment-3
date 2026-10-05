using RefactoringLab;

var aramexShipping = new ShippingCostCalculator(
    new AramexCalculator());

Console.WriteLine(
    $"Aramex 2kg → {aramexShipping.Calculate(2)}");

var fedExShipping = new ShippingCostCalculator(
    new FedExCalculator());

Console.WriteLine(
    $"FedEx 2kg → {fedExShipping.Calculate(2)}");

var dhlShipping = new ShippingCostCalculator(
    new DHLCalculator());

Console.WriteLine(
    $"DHL 2kg → {dhlShipping.Calculate(2)}");




var processor = new OrderProcessor(
    new SqlOrderRepository(),
    new SmtpEmailSender());

processor.Process(
    1001,
    "customer@example.com");

Console.WriteLine();



var email = new Notification(
    new EmailChannel(),
    urgent: true,
    sendAt: DateTime.Today.AddHours(18));

email.Send(
    "customer@example.com",
    "Your order ships tomorrow");


var sms = new Notification(
    new SmsChannel(),
    urgent: true);

sms.Send(
    "+201000000000",
    "OTP 4821");


var whatsapp = new Notification(
    new WhatsAppChannel(),
    urgent: true);

whatsapp.Send(
    "+201000000000",
    "Your order ships tomorrow");