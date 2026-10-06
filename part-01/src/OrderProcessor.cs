namespace RefactoringLab;
 public interface IOrderRepository
{
    public void process(int orderId, DateTime processedAt);

}
public interface IEmailSender
{
    public void Send(string to, string body);
}


 public class OrderProcessor
 {
    private readonly IOrderRepository orderRepository;
    private readonly IEmailSender emailSender;

    public OrderProcessor( IOrderRepository orderRepository, IEmailSender emailSender)
    {
        this.orderRepository = orderRepository;
        this.emailSender = emailSender;
    }
    public void Process(int orderId, string customerEmail)
    {
        var processedAt = DateTime.Now;

        orderRepository.process(orderId, processedAt);

        emailSender.Send(
            customerEmail,
            $"Order {orderId} confirmed at {processedAt}");
    }
}

public class SqlOrderRepository: IOrderRepository
{
    public void process(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public class SmtpEmailSender: IEmailSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}
